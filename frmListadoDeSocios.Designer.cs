namespace prySerafiniGiorgi_IEFI
{
    partial class frmListadoDeSocios
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.grpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.lblTotalSueldos = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblPersonasInscr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpConsultaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(17, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(494, 201);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grpConsultaDatos
            // 
            this.grpConsultaDatos.Controls.Add(this.lblPromedioSaldos);
            this.grpConsultaDatos.Controls.Add(this.lblTotalSueldos);
            this.grpConsultaDatos.Controls.Add(this.cmdListar);
            this.grpConsultaDatos.Controls.Add(this.lblPersonasInscr);
            this.grpConsultaDatos.Controls.Add(this.label3);
            this.grpConsultaDatos.Controls.Add(this.label2);
            this.grpConsultaDatos.Controls.Add(this.label1);
            this.grpConsultaDatos.Controls.Add(this.dgvGrilla);
            this.grpConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpConsultaDatos.Name = "grpConsultaDatos";
            this.grpConsultaDatos.Size = new System.Drawing.Size(523, 474);
            this.grpConsultaDatos.TabIndex = 1;
            this.grpConsultaDatos.TabStop = false;
            this.grpConsultaDatos.Text = "Consulta de datos";
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(251, 329);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(260, 32);
            this.lblPromedioSaldos.TabIndex = 11;
            // 
            // lblTotalSueldos
            // 
            this.lblTotalSueldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSueldos.Location = new System.Drawing.Point(251, 241);
            this.lblTotalSueldos.Name = "lblTotalSueldos";
            this.lblTotalSueldos.Size = new System.Drawing.Size(260, 32);
            this.lblTotalSueldos.TabIndex = 10;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(17, 382);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(428, 23);
            this.cmdListar.TabIndex = 9;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblPersonasInscr
            // 
            this.lblPersonasInscr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPersonasInscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasInscr.Location = new System.Drawing.Point(251, 285);
            this.lblPersonasInscr.Name = "lblPersonasInscr";
            this.lblPersonasInscr.Size = new System.Drawing.Size(260, 32);
            this.lblPersonasInscr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de personas inscriptas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio de saldos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de saldos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            // 
            // frmListadoDeSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpConsultaDatos);
            this.Name = "frmListadoDeSocios";
            this.Text = "Listado de socios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpConsultaDatos.ResumeLayout(false);
            this.grpConsultaDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox grpConsultaDatos;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.Label lblTotalSueldos;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblPersonasInscr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}