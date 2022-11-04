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
            actividad.Listar(lstActividades);

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(lstActividades.SelectedValue);
            clsSocio listado = new clsSocio();
            listado.FiltrarClientesDeUnaActividad(dgvListado,id );
        }
    }
}
