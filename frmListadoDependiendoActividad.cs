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
    public partial class frmListadoDependiendoActividad : Form
    {
        public frmListadoDependiendoActividad()
        {
            InitializeComponent();
        }

        private void frmListadoDependiendoActividad_Load(object sender, EventArgs e)
        {
            clsActividad actividad = new clsActividad();
            actividad.Listar(lstActividades);

        }
    }
}
