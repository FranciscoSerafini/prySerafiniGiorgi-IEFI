﻿using System;
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

                txtNombre.Text = objCliente.Nombre_Apellido;
                mskDni.Text = objCliente.Dni_Socio.ToString();
                txtDireccion.Text = objCliente.Direccion;
                mskCodigoActividad.Text = objCliente.CodigoActividad.ToString();
                mskCodigoSucursal.Text = objCliente.CodigoSucursal.ToString();
                mskSaldo.Text = objCliente.Saldo.ToString();



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
            eliminar.BajaDeSocios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 dni = (Convert.ToInt32(mskDni.Text));
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            Int32 codigoSuc = (Convert.ToInt32(mskCodigoSucursal.Text));
            Int32 codigoAct = (Convert.ToInt32(mskCodigoActividad.Text));
            Int32 saldo = (Convert.ToInt32(mskSaldo.Text));
            clsSocio modificar = new clsSocio();
            modificar.Dni_Socio = dni;
            modificar.Nombre_Apellido = nombre;
            modificar.Direccion = direccion;
            modificar.CodigoSucursal = codigoSuc;
            modificar.CodigoActividad = codigoAct;
            modificar.Saldo = saldo;
            modificar.ModificarSocios(dni);


        }
    }
}