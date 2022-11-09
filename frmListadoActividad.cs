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
            //lblPromedio.Text = filtrar.promedioSaldo.ToString();
            lblSaldoTotal.Text = filtrar.TotalSaldo.ToString();
            filtrar.FiltrarClientesDeUnaActividad(dgvListadoSucursales,filtro);

        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();//nos abre la interfaz de usuario para ver elegir donde queremos la impresion
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings; //asginamos la impresora que elegimos en la ventana
            prtDocumento.Print();//ejecutara el metodo print
            MessageBox.Show("Su reporte fue impreso");

        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio reporte = new clsSocio();
            reporte.Imprimir(e);
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            clsSocio objCliente = new clsSocio();
            objCliente.ExportarClientes();

        }
    }
}
