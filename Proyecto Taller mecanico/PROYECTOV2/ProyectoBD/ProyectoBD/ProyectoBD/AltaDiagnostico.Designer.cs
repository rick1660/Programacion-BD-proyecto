namespace ProyectoBD
{
    partial class AltaDiagnostico
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
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdDiagnostico = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.IdVehiculo = new System.Windows.Forms.Label();
            this.lblCausa = new System.Windows.Forms.Label();
            this.lblFalla = new System.Windows.Forms.Label();
            this.lblIdDiag = new System.Windows.Forms.Label();
            this.lblAltaCliente = new System.Windows.Forms.Label();
            this.DataGAlta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(45, 181);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(183, 22);
            this.txtIdVehiculo.TabIndex = 26;
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(469, 99);
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(289, 22);
            this.txtCausa.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(469, 127);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(285, 102);
            this.txtDescripcion.TabIndex = 23;
            // 
            // txtIdDiagnostico
            // 
            this.txtIdDiagnostico.Location = new System.Drawing.Point(205, 99);
            this.txtIdDiagnostico.Name = "txtIdDiagnostico";
            this.txtIdDiagnostico.Size = new System.Drawing.Size(155, 22);
            this.txtIdDiagnostico.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(278, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(253, 34);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // IdVehiculo
            // 
            this.IdVehiculo.AutoSize = true;
            this.IdVehiculo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdVehiculo.Location = new System.Drawing.Point(82, 146);
            this.IdVehiculo.Name = "IdVehiculo";
            this.IdVehiculo.Size = new System.Drawing.Size(116, 16);
            this.IdVehiculo.TabIndex = 19;
            this.IdVehiculo.Text = "ID del Vehiculo:";
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausa.Location = new System.Drawing.Point(384, 99);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(55, 16);
            this.lblCausa.TabIndex = 18;
            this.lblCausa.Text = "Causa:";
            // 
            // lblFalla
            // 
            this.lblFalla.AutoSize = true;
            this.lblFalla.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalla.Location = new System.Drawing.Point(292, 169);
            this.lblFalla.Name = "lblFalla";
            this.lblFalla.Size = new System.Drawing.Size(171, 16);
            this.lblFalla.TabIndex = 16;
            this.lblFalla.Text = "Descripcion de la Falla:";
            // 
            // lblIdDiag
            // 
            this.lblIdDiag.AutoSize = true;
            this.lblIdDiag.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDiag.Location = new System.Drawing.Point(42, 99);
            this.lblIdDiag.Name = "lblIdDiag";
            this.lblIdDiag.Size = new System.Drawing.Size(135, 16);
            this.lblIdDiag.TabIndex = 15;
            this.lblIdDiag.Text = "ID de Diagnostico:";
            // 
            // lblAltaCliente
            // 
            this.lblAltaCliente.AutoSize = true;
            this.lblAltaCliente.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCliente.Location = new System.Drawing.Point(247, 9);
            this.lblAltaCliente.Name = "lblAltaCliente";
            this.lblAltaCliente.Size = new System.Drawing.Size(338, 38);
            this.lblAltaCliente.TabIndex = 14;
            this.lblAltaCliente.Text = "ALTA DIAGNOSTICO";
            // 
            // DataGAlta
            // 
            this.DataGAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGAlta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGAlta.Location = new System.Drawing.Point(45, 250);
            this.DataGAlta.Name = "DataGAlta";
            this.DataGAlta.RowHeadersWidth = 51;
            this.DataGAlta.RowTemplate.Height = 24;
            this.DataGAlta.Size = new System.Drawing.Size(734, 244);
            this.DataGAlta.TabIndex = 34;
            // 
            // AltaDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.DataGAlta);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.txtCausa);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdDiagnostico);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.IdVehiculo);
            this.Controls.Add(this.lblCausa);
            this.Controls.Add(this.lblFalla);
            this.Controls.Add(this.lblIdDiag);
            this.Controls.Add(this.lblAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaDiagnostico";
            this.Text = "AltaDiagnostico";
            this.Load += new System.EventHandler(this.AltaDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdDiagnostico;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label IdVehiculo;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.Label lblFalla;
        private System.Windows.Forms.Label lblIdDiag;
        private System.Windows.Forms.Label lblAltaCliente;
        private System.Windows.Forms.DataGridView DataGAlta;
    }
}