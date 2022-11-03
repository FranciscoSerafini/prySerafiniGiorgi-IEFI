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
    public partial class frmNuevosSocios : Form
    {
        public frmNuevosSocios()
        {
            InitializeComponent();
        }

        private void frmAgregarNuevosClientes_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarCliente_Click(object sender, EventArgs e)
        {
            clsSocio agregado = new clsSocio();
            agregado.Dni_Socio = Convert.ToInt32(mskDni.Text);
            agregado.Nombre_Apellido = txtNombre.Text;
            agregado.Direccion = txtDireccion.Text;
            agregado.CodigoSucursal = Convert.ToInt32(mskCodigoSucursal.Text);
            agregado.CodigoActividad = Convert.ToInt32(mskCodigoSucursal.Text);
            agregado.Saldo = Convert.ToInt32(mskSaldo.Text);
            agregado.RegistroClientes();

        }
    }
}
