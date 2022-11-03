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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(txtDni.Text);
            clsSocio objCliente = new clsSocio();
            objCliente.Buscar(DniCliente);

            if (DniCliente != 0)
            {
                //le damos valor a las cajas de texto
                lblNombre.Text = objCliente.Nombre_Apellido;
                lblSaldo.Text = objCliente.Saldo.ToString();
                
            }
            else
            {
                MessageBox.Show("Dni no encontrado");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(txtDni.Text);
            clsSocio eliminar = new clsSocio();
            eliminar.Dni_Socio = DniCliente;
            eliminar.BajaDeClientes();
        }
    }
}
