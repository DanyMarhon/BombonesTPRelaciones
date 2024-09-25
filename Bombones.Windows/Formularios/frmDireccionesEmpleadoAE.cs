using Bombones.Entidades.Entidades;
using Bombones.Entidades.ViewModels;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones.Windows.Formularios
{
    public partial class frmDireccionesEmpleadoAE : Form
    {
        public frmDireccionesEmpleadoAE()
        {
            InitializeComponent();
        }

        private readonly IServiceProvider? _serviceProvider;

        private Direccion? direccion;

        private Pais? pais;
        private ProvinciaEstado? provinciaEstado;
        private Ciudad? ciudad;
        public frmDireccionesEmpleadoAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboPaises(ref cboPaises, _serviceProvider);
        }

        private void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            pais = cboPaises.SelectedIndex > 0 ?
                (Pais?)cboPaises.SelectedItem : null;
            if (pais is not null)
            {
                CombosHelper.CargarComboProvinciaEstado(ref cboProvinciasEstados, pais, _serviceProvider);
            }
            else
            {
                cboProvinciasEstados.DataSource = null;
            }
        }

        private void cboProvinciasEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            provinciaEstado = cboProvinciasEstados.SelectedIndex > 0 ?
                (ProvinciaEstado?)cboProvinciasEstados.SelectedItem : null;
            if (provinciaEstado is not null)
            {
                CombosHelper.CargarComboCiudades(ref cboCiudades, pais,
                    provinciaEstado,
                     _serviceProvider);
            }
            else
            {
                cboCiudades.DataSource = null;
            }
        }

        private void cboCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cboCiudades.SelectedIndex > 0 ?
               (Ciudad?)cboCiudades.SelectedItem : null;
        }
    }
}
