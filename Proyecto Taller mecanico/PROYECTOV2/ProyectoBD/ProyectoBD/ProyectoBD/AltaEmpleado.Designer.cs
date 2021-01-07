namespace ProyectoBD
{
    partial class AltaEmpleado
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
            this.txtIdDepar = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIDVehic = new System.Windows.Forms.Label();
            this.lblIdDep = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblAltaEmpleado = new System.Windows.Forms.Label();
            this.DataGAlta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(578, 133);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(181, 22);
            this.txtIdVehiculo.TabIndex = 26;
            // 
            // txtIdDepar
            // 
            this.txtIdDepar.Location = new System.Drawing.Point(578, 83);
            this.txtIdDepar.Name = "txtIdDepar";
            this.txtIdDepar.Size = new System.Drawing.Size(181, 22);
            this.txtIdDepar.TabIndex = 25;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(126, 183);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(235, 22);
            this.txtTelef.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 22);
            this.txtNombre.TabIndex = 23;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(189, 83);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(172, 22);
            this.txtEmpleado.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(277, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(253, 34);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIDVehic
            // 
            this.lblIDVehic.AutoSize = true;
            this.lblIDVehic.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVehic.Location = new System.Drawing.Point(424, 133);
            this.lblIDVehic.Name = "lblIDVehic";
            this.lblIDVehic.Size = new System.Drawing.Size(116, 16);
            this.lblIDVehic.TabIndex = 19;
            this.lblIDVehic.Text = "ID del Vehiculo:";
            // 
            // lblIdDep
            // 
            this.lblIdDep.AutoSize = true;
            this.lblIdDep.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDep.Location = new System.Drawing.Point(385, 83);
            this.lblIdDep.Name = "lblIdDep";
            this.lblIdDep.Size = new System.Drawing.Size(155, 16);
            this.lblIdDep.TabIndex = 18;
            this.lblIdDep.Text = "ID del Departamento:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(43, 183);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(73, 16);
            this.lblTelef.TabIndex = 17;
            this.lblTelef.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(43, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(43, 83);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(125, 16);
            this.lblIdEmpleado.TabIndex = 15;
            this.lblIdEmpleado.Text = "ID del Empleado:";
            // 
            // lblAltaEmpleado
            // 
            this.lblAltaEmpleado.AutoSize = true;
            this.lblAltaEmpleado.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaEmpleado.Location = new System.Drawing.Point(259, 9);
            this.lblAltaEmpleado.Name = "lblAltaEmpleado";
            this.lblAltaEmpleado.Size = new System.Drawing.Size(293, 38);
            this.lblAltaEmpleado.TabIndex = 14;
            this.lblAltaEmpleado.Text = "ALTA EMPLEADO";
            // 
            // DataGAlta
            // 
            this.DataGAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGAlta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGAlta.Location = new System.Drawing.Point(36, 246);
            this.DataGAlta.Name = "DataGAlta";
            this.DataGAlta.RowHeadersWidth = 51;
            this.DataGAlta.RowTemplate.Height = 24;
            this.DataGAlta.Size = new System.Drawing.Size(734, 244);
            this.DataGAlta.TabIndex = 34;
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.DataGAlta);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.txtIdDepar);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIDVehic);
            this.Controls.Add(this.lblIdDep);
            this.Controls.Add(this.lblTelef);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.lblAltaEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaEmpleado";
            this.Text = "AltaEmpleado";
            this.Load += new System.EventHandler(this.AltaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.TextBox txtIdDepar;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIDVehic;
        private System.Windows.Forms.Label lblIdDep;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblAltaEmpleado;
        private System.Windows.Forms.DataGridView DataGAlta;
    }
}