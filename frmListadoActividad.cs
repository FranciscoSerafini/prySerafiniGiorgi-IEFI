using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniGiorgi_IEFI
{
    public partial class frmListadoActividad : Form
    {
        public frmListadoActividad()
        {
            InitializeComponent();
        }

        private void frmListadoDependiendoActividad_Load(object sender, EventArgs e)
        {
            clsActividad actividad = new clsActividad();
            actividad.ListarC(lstActividades);

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 filtro = (Convert.ToInt32(lstActividades.SelectedValue));
            clsSocio filtrar = new clsSocio();
            filtrar.FiltrarClientesDeUnaActividad(dgvListadoSucursales,filtro);
        }
    }
}
