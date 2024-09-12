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
        private List<EmpleadoListDto>? lista;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

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

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                totalRecords = _servicio!.GetCantidad();
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize);
                MostrarDatosEnGrilla(lista);
                if (cboPaginas.Items.Count != totalPages)
                {
                    CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                }
                txtCantidadPaginas.Text = totalPages.ToString();
                cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
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
    }
}
