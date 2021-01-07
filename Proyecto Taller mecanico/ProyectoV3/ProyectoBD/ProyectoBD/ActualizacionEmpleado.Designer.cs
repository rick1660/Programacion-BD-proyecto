namespace ProyectoBD
{
    partial class ActualizacionEmpleado
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIDVehic = new System.Windows.Forms.Label();
            this.lblIdDep = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblActualizacionEmp = new System.Windows.Forms.Label();
            this.DataGActualizar = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(579, 128);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(181, 22);
            this.txtIdVehiculo.TabIndex = 38;
            // 
            // txtIdDepar
            // 
            this.txtIdDepar.Location = new System.Drawing.Point(579, 78);
            this.txtIdDepar.Name = "txtIdDepar";
            this.txtIdDepar.Size = new System.Drawing.Size(181, 22);
            this.txtIdDepar.TabIndex = 37;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(127, 178);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(235, 22);
            this.txtTelef.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 22);
            this.txtNombre.TabIndex = 35;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(190, 78);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(172, 22);
            this.txtEmpleado.TabIndex = 34;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(262, 513);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(253, 34);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "ACTUALIZACION";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIDVehic
            // 
            this.lblIDVehic.AutoSize = true;
            this.lblIDVehic.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVehic.Location = new System.Drawing.Point(425, 128);
            this.lblIDVehic.Name = "lblIDVehic";
            this.lblIDVehic.Size = new System.Drawing.Size(116, 16);
            this.lblIDVehic.TabIndex = 32;
            this.lblIDVehic.Text = "ID del Vehiculo:";
            // 
            // lblIdDep
            // 
            this.lblIdDep.AutoSize = true;
            this.lblIdDep.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDep.Location = new System.Drawing.Point(386, 78);
            this.lblIdDep.Name = "lblIdDep";
            this.lblIdDep.Size = new System.Drawing.Size(155, 16);
            this.lblIdDep.TabIndex = 31;
            this.lblIdDep.Text = "ID del Departamento:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(44, 178);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(73, 16);
            this.lblTelef.TabIndex = 30;
            this.lblTelef.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(44, 78);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(125, 16);
            this.lblIdEmpleado.TabIndex = 28;
            this.lblIdEmpleado.Text = "ID del Empleado:";
            // 
            // lblActualizacionEmp
            // 
            this.lblActualizacionEmp.AutoSize = true;
            this.lblActualizacionEmp.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizacionEmp.Location = new System.Drawing.Point(166, 9);
            this.lblActualizacionEmp.Name = "lblActualizacionEmp";
            this.lblActualizacionEmp.Size = new System.Drawing.Size(480, 38);
            this.lblActualizacionEmp.TabIndex = 27;
            this.lblActualizacionEmp.Text = "ACTUALIZACION EMPLEADO";
            // 
            // DataGActualizar
            // 
            this.DataGActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGActualizar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGActualizar.Location = new System.Drawing.Point(35, 229);
            this.DataGActualizar.Name = "DataGActualizar";
            this.DataGActualizar.RowHeadersWidth = 51;
            this.DataGActualizar.RowTemplate.Height = 24;
            this.DataGActualizar.Size = new System.Drawing.Size(734, 264);
            this.DataGActualizar.TabIndex = 52;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(682, 513);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 34);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ActualizacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DataGActualizar);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.txtIdDepar);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblIDVehic);
            this.Controls.Add(this.lblIdDep);
            this.Controls.Add(this.lblTelef);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.lblActualizacionEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizacionEmpleado";
            this.Text = "ActualizacionEmpleado";
            this.Load += new System.EventHandler(this.ActualizacionEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.TextBox txtIdDepar;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblIDVehic;
        private System.Windows.Forms.Label lblIdDep;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblActualizacionEmp;
        private System.Windows.Forms.DataGridView DataGActualizar;
        private System.Windows.Forms.Button btnGuardar;
    }
}