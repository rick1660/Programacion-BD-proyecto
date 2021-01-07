namespace ProyectoBD
{
    partial class AltaAutomovil
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
            this.lblAltaAuto = new System.Windows.Forms.Label();
            this.txtFechaR = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.DataGAlta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaAuto
            // 
            this.lblAltaAuto.AutoSize = true;
            this.lblAltaAuto.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaAuto.Location = new System.Drawing.Point(252, 9);
            this.lblAltaAuto.Name = "lblAltaAuto";
            this.lblAltaAuto.Size = new System.Drawing.Size(303, 38);
            this.lblAltaAuto.TabIndex = 14;
            this.lblAltaAuto.Text = "ALTA AUTOMOVIL";
            // 
            // txtFechaR
            // 
            this.txtFechaR.Location = new System.Drawing.Point(573, 217);
            this.txtFechaR.Name = "txtFechaR";
            this.txtFechaR.Size = new System.Drawing.Size(163, 22);
            this.txtFechaR.TabIndex = 27;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(476, 170);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(86, 22);
            this.txtAño.TabIndex = 26;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(476, 120);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(157, 22);
            this.txtColor.TabIndex = 25;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(134, 223);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(217, 22);
            this.txtMarca.TabIndex = 24;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(180, 170);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(171, 22);
            this.txtSerie.TabIndex = 23;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(195, 73);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(156, 22);
            this.txtVehiculo.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(272, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(253, 34);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.Location = new System.Drawing.Point(391, 220);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(141, 32);
            this.lblFechaR.TabIndex = 20;
            this.lblFechaR.Text = "Fecha de Registro:\r\n(DD-MM-AA)";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(391, 170);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(39, 16);
            this.lblAño.TabIndex = 19;
            this.lblAño.Text = "Año:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(391, 120);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 16);
            this.lblColor.TabIndex = 18;
            this.lblColor.Text = "Color:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(51, 223);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(51, 173);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(98, 16);
            this.lblSerie.TabIndex = 16;
            this.lblSerie.Text = "No. de Serie:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(51, 76);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(116, 16);
            this.lblVehiculo.TabIndex = 15;
            this.lblVehiculo.Text = "ID del Vehiculo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(476, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(289, 22);
            this.txtModelo.TabIndex = 30;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(391, 79);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 16);
            this.lblModelo.TabIndex = 28;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(195, 120);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(156, 22);
            this.txtCliente.TabIndex = 32;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(51, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(106, 16);
            this.lblCliente.TabIndex = 31;
            this.lblCliente.Text = "ID del Cliente:";
            // 
            // DataGAlta
            // 
            this.DataGAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGAlta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGAlta.Location = new System.Drawing.Point(31, 263);
            this.DataGAlta.Name = "DataGAlta";
            this.DataGAlta.RowHeadersWidth = 51;
            this.DataGAlta.RowTemplate.Height = 24;
            this.DataGAlta.Size = new System.Drawing.Size(734, 244);
            this.DataGAlta.TabIndex = 33;
            // 
            // AltaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.DataGAlta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtFechaR);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaR);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblAltaAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaAutomovil";
            this.Text = "AltaAutomovil";
            this.Load += new System.EventHandler(this.AltaAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAltaAuto;
        private System.Windows.Forms.TextBox txtFechaR;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView DataGAlta;
    }
}