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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAgregarNuevosClientes objVentanaNuevosClientes = new frmAgregarNuevosClientes();
            objVentanaNuevosClientes.ShowDialog();

        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevosClientes objVentanaBuscarCliente = new frmAgregarNuevosClientes();
            objVentanaBuscarCliente.ShowDialog();
        }
    }
}
