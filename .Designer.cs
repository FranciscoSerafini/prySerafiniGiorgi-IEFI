namespace prySerafiniGiorgi_IEFI
{
    partial class frmBuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCliente));
            this.lblDni = new System.Windows.Forms.Label();
            this.grpDatosClientes = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaldo1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.lblDni1 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.lblSaldo4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAcitividad = new System.Windows.Forms.ComboBox();
            this.lstSucursal = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.mskSaldo = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpDatosClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(12, 19);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // grpDatosClientes
            // 
            this.grpDatosClientes.Controls.Add(this.lblSaldo);
            this.grpDatosClientes.Controls.Add(this.lblNombre);
            this.grpDatosClientes.Controls.Add(this.lblSaldo1);
            this.grpDatosClientes.Controls.Add(this.lblNombre1);
            this.grpDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosClientes.Location = new System.Drawing.Point(12, 93);
            this.grpDatosClientes.Name = "grpDatosClientes";
            this.grpDatosClientes.Size = new System.Drawing.Size(298, 109);
            this.grpDatosClientes.TabIndex = 8;
            this.grpDatosClientes.TabStop = false;
            this.grpDatosClientes.Text = "Datos del cliente";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldo.Location = new System.Drawing.Point(153, 70);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(113, 26);
            this.lblSaldo.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(85, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(181, 26);
            this.lblNombre.TabIndex = 11;
            // 
            // lblSaldo1
            // 
            this.lblSaldo1.AutoSize = true;
            this.lblSaldo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo1.Location = new System.Drawing.Point(6, 71);
            this.lblSaldo1.Name = "lblSaldo1";
            this.lblSaldo1.Size = new System.Drawing.Size(44, 15);
            this.lblSaldo1.TabIndex = 10;
            this.lblSaldo1.Text = "Saldo";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(6, 25);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(58, 15);
            this.lblNombre1.TabIndex = 8;
            this.lblNombre1.Text = "Nombre";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(49, 18);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(156, 21);
            this.txtDni.TabIndex = 9;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Enabled = false;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(130, 44);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 10;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(226, 208);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(226, 493);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 12;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDni1
            // 
            this.lblDni1.AutoSize = true;
            this.lblDni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni1.Location = new System.Drawing.Point(0, 25);
            this.lblDni1.Name = "lblDni1";
            this.lblDni1.Size = new System.Drawing.Size(35, 15);
            this.lblDni1.TabIndex = 8;
            this.lblDni1.Text = "DNI:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(0, 101);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 15);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(0, 63);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(62, 15);
            this.lblNombre2.TabIndex = 10;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSucursal.Location = new System.Drawing.Point(0, 139);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(120, 15);
            this.lblNombreSucursal.TabIndex = 11;
            this.lblNombreSucursal.Text = "Nombre sucursal:";
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreActividad.Location = new System.Drawing.Point(0, 177);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(147, 15);
            this.lblNombreActividad.TabIndex = 12;
            this.lblNombreActividad.Text = "Nombre de actividad :";
            // 
            // lblSaldo4
            // 
            this.lblSaldo4.AutoSize = true;
            this.lblSaldo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo4.Location = new System.Drawing.Point(0, 215);
            this.lblSaldo4.Name = "lblSaldo4";
            this.lblSaldo4.Size = new System.Drawing.Size(48, 15);
            this.lblSaldo4.TabIndex = 13;
            this.lblSaldo4.Text = "Saldo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAcitividad);
            this.groupBox1.Controls.Add(this.lstSucursal);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.mskDni);
            this.groupBox1.Controls.Add(this.mskSaldo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblSaldo4);
            this.groupBox1.Controls.Add(this.lblNombreActividad);
            this.groupBox1.Controls.Add(this.lblNombreSucursal);
            this.groupBox1.Controls.Add(this.lblNombre2);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblDni1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 250);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // lstAcitividad
            // 
            this.lstAcitividad.FormattingEnabled = true;
            this.lstAcitividad.Location = new System.Drawing.Point(154, 174);
            this.lstAcitividad.Name = "lstAcitividad";
            this.lstAcitividad.Size = new System.Drawing.Size(134, 23);
            this.lstAcitividad.TabIndex = 24;
            // 
            // lstSucursal
            // 
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.Location = new System.Drawing.Point(154, 139);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.Size = new System.Drawing.Size(134, 23);
            this.lstSucursal.TabIndex = 23;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(154, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(134, 21);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // mskDni
            // 
            this.mskDni.Location = new System.Drawing.Point(154, 25);
            this.mskDni.Mask = "99999999";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(134, 21);
            this.mskDni.TabIndex = 20;
            this.mskDni.ValidatingType = typeof(int);
            this.mskDni.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDni_MaskInputRejected);
            // 
            // mskSaldo
            // 
            this.mskSaldo.Location = new System.Drawing.Point(154, 210);
            this.mskSaldo.Mask = "9999";
            this.mskSaldo.Name = "mskSaldo";
            this.mskSaldo.Size = new System.Drawing.Size(134, 21);
            this.mskSaldo.TabIndex = 19;
            this.mskSaldo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSaldo_MaskInputRejected);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 21);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.grpDatosClientes);
            this.Controls.Add(this.lblDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar cliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.grpDatosClientes.ResumeLayout(false);
            this.grpDatosClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox grpDatosClientes;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSaldo1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Label lblDni1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.Label lblNombreActividad;
        private System.Windows.Forms.Label lblSaldo4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.MaskedTextBox mskSaldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox lstSucursal;
        private System.Windows.Forms.ComboBox lstAcitividad;
    }
}