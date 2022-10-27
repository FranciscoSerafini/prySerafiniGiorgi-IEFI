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
    public partial class frmListadoDeSocios : Form
    {
        public frmListadoDeSocios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsSocio objCliente = new clsSocio();
            objCliente.Listar(dgvGrilla);
        }
    }
}
