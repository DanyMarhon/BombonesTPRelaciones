using Bombones.Entidades.Entidades;
using Bombones.Entidades.ViewModels;
using Bombones.Windows.Helpers;
using System.Data;
using System.Text.RegularExpressions;

namespace Bombones.Windows.Formularios
{
    public partial class frmEmpleadosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;

        private Empleado? empleado;
        public frmEmpleadosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        //private void btnAgregarDireccion_Click(object sender, EventArgs e)
        //{
        //    frmDireccionAE frm = new frmDireccionAE(_serviceProvider);
        //    DialogResult dr = frm.ShowDialog(this);
        //    if (dr == DialogResult.Cancel) return;

        //    DireccionConTipoVm? direccionConTipo = frm.GetDireccion();
        //    if (direccionConTipo is null) return;
        //    // Verifica si la dirección ya existe en la lista
        //    if (direcciones.Any(dt => dt.Direccion
        //        .Equals(direccionConTipo?.Direccion)))
        //    {
        //        MessageBox.Show("La dirección ya existe en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    direcciones.Add(direccionConTipo);
        //    var r = GridHelper.ConstruirFila(dgvDirecciones);
        //    GridHelper.SetearFila(r, direccionConTipo.Direccion);
        //    GridHelper.AgregarFila(r, dgvDirecciones);

        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (empleado is null)
                {
                    empleado = new Empleado();
                }
                empleado.Apellido = txtApellido.Text;
                empleado.Nombre = txtNombre.Text;
                empleado.FechaContratacion = monthCalendar1.SelectionStart;
            }
            DialogResult = DialogResult.OK;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Apellido es requerido");
            }
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "Nombre es requerido");
            }
            //if (empleado.Direccion.Count == 0)
            //{
            //    valido = false;
                
            //}

            return valido;
        }

        //private void btnBorrarDireccion_Click(object sender, EventArgs e)
        //{
        //    if (dgvDirecciones.SelectedRows.Count == 0) return;
        //    var r = dgvDirecciones.SelectedRows[0];
        //    if (r is null) return;

        //    DireccionConTipoVm? direccionConTipoVm = (DireccionConTipoVm?)r.Tag;
        //    if (direccionConTipoVm is null) return;

        //    DialogResult dr = MessageBox.Show("¿Desea borrar la dirección?",
        //        "Confirmar", MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question,
        //        MessageBoxDefaultButton.Button2);
        //    if (dr == DialogResult.No) return;

        //    direcciones.Remove(direccionConTipoVm);
        //    GridHelper.QuitarFila(r, dgvDirecciones);
        //}

        public Empleado? GetEmpleado()
        {
            return empleado;
        }

        public void SetEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            frmDireccionesEmpleadoAE frm = new frmDireccionesEmpleadoAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
        }
    }
}
