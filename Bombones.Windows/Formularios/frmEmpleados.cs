using Bombones.Entidades.Dtos;
using Bombones.Servicios.Intefaces;
using Bombones.Entidades.Entidades;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Bombones.Windows.Formularios
{
    public partial class frmEmpleados : Form
    {

        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosEmpleados? _servicio;
        private List<EmpleadoListDto>? lista = null!;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

        private Func<EmpleadoListDto, bool>? filter = null;
        public frmEmpleados(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosEmpleados>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            //frmEmpleadosAE frm = new frmEmpleadosAE(_serviceProvider) { Text = "Agregar Empleado" };
            //DialogResult dr = frm.ShowDialog(this);
            //if (dr == DialogResult.Cancel) return;
            //Empleado? empleado = frm.GetCliente();
            //if (empleado is null) return;
            //try
            //{
            //    if (_servicio is null)
            //    {
            //        throw new ApplicationException("Dependencias no cargadas");
            //    }
            //    _servicio.Guardar(cliente);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            currentPage = 1;
            tsbFiltrar.Enabled = true;
            tsbFiltrar.BackColor = SystemColors.Control;
            RecargarGrilla();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicio!.GetCantidad(filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(filter);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(filter);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData(filter);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(filter);
            }
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }

        private void LoadData(Func<EmpleadoListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize, filter);
                if (lista.Count > 0)
                {
                    MostrarDatosEnGrilla(lista);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtCantidadPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;

                }
                else
                {
                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentPage = 1;
                    filter = null;
                    tsbFiltrar.Enabled = true;
                    tsbFiltrar.BackColor = SystemColors.Control;
                    RecargarGrilla();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla(List<EmpleadoListDto> lista)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var e in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, e);
                    GridHelper.AgregarFila(r, dgvDatos);
                }

            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            frmFiltroTexto frm = new frmFiltroTexto() { Text = "Ingresar texto para buscar por apellido" };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty)
                {
                    return;
                }
                filter = e => e.Apellido.ToUpper()
                    .Contains(textoFiltro.ToUpper());
                totalRecords = _servicio!.GetCantidad(filter);
                currentPage = 1;
                if (totalRecords > 0)
                {
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    tsbFiltrar.Enabled = false;
                    tsbFiltrar.BackColor = Color.Orange;

                    LoadData(filter);

                }
                else
                {

                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    filter = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
