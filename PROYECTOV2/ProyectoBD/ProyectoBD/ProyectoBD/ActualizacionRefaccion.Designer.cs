namespace ProyectoBD
{
    partial class ActualizacionRefaccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtFechaE = new System.Windows.Forms.TextBox();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtFechaS = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIdRefaccion = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.lblFechaS = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblIdRefaccion = new System.Windows.Forms.Label();
            this.lblAltaRefaccion = new System.Windows.Forms.Label();
            this.DataGActualizar = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "$";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 22);
            this.txtNombre.TabIndex = 64;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 136);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 63;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtFechaE
            // 
            this.txtFechaE.Location = new System.Drawing.Point(532, 95);
            this.txtFechaE.Name = "txtFechaE";
            this.txtFechaE.Size = new System.Drawing.Size(180, 22);
            this.txtFechaE.TabIndex = 62;
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaE.Location = new System.Drawing.Point(387, 95);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(135, 32);
            this.lblFechaE.TabIndex = 61;
            this.lblFechaE.Text = "Fecha de Entrada:\r\n(DD-MM-AA)";
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(555, 198);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(157, 22);
            this.txtDepart.TabIndex = 60;
            // 
            // txtFechaS
            // 
            this.txtFechaS.Location = new System.Drawing.Point(532, 156);
            this.txtFechaS.Name = "txtFechaS";
            this.txtFechaS.Size = new System.Drawing.Size(180, 22);
            this.txtFechaS.TabIndex = 59;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(138, 186);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(114, 22);
            this.txtCosto.TabIndex = 58;
            // 
            // txtIdRefaccion
            // 
            this.txtIdRefaccion.Location = new System.Drawing.Point(191, 89);
            this.txtIdRefaccion.Name = "txtIdRefaccion";
            this.txtIdRefaccion.Size = new System.Drawing.Size(156, 22);
            this.txtIdRefaccion.TabIndex = 57;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(269, 513);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(253, 34);
            this.btnActualizar.TabIndex = 56;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDepartamento.Location = new System.Drawing.Point(387, 204);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(111, 16);
            this.lblIdDepartamento.TabIndex = 55;
            this.lblIdDepartamento.Text = "Departamento:";
            // 
            // lblFechaS
            // 
            this.lblFechaS.AutoSize = true;
            this.lblFechaS.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaS.Location = new System.Drawing.Point(387, 146);
            this.lblFechaS.Name = "lblFechaS";
            this.lblFechaS.Size = new System.Drawing.Size(119, 32);
            this.lblFechaS.TabIndex = 54;
            this.lblFechaS.Text = "Fecha de Salida\r\n(DD-MM-AA)";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(47, 189);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(53, 16);
            this.lblCosto.TabIndex = 53;
            this.lblCosto.Text = "Costo:";
            // 
            // lblIdRefaccion
            // 
            this.lblIdRefaccion.AutoSize = true;
            this.lblIdRefaccion.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRefaccion.Location = new System.Drawing.Point(47, 92);
            this.lblIdRefaccion.Name = "lblIdRefaccion";
            this.lblIdRefaccion.Size = new System.Drawing.Size(122, 16);
            this.lblIdRefaccion.TabIndex = 52;
            this.lblIdRefaccion.Text = "ID de Refaccion:";
            // 
            // lblAltaRefaccion
            // 
            this.lblAltaRefaccion.AutoSize = true;
            this.lblAltaRefaccion.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaRefaccion.Location = new System.Drawing.Point(169, 9);
            this.lblAltaRefaccion.Name = "lblAltaRefaccion";
            this.lblAltaRefaccion.Size = new System.Drawing.Size(487, 38);
            this.lblAltaRefaccion.TabIndex = 51;
            this.lblAltaRefaccion.Text = "ACTUALIZACION REFACCION";
            // 
            // DataGActualizar
            // 
            this.DataGActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGActualizar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGActualizar.Location = new System.Drawing.Point(35, 244);
            this.DataGActualizar.Name = "DataGActualizar";
            this.DataGActualizar.RowHeadersWidth = 51;
            this.DataGActualizar.RowTemplate.Height = 24;
            this.DataGActualizar.Size = new System.Drawing.Size(734, 244);
            this.DataGActualizar.TabIndex = 66;
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
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ActualizacionRefaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DataGActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFechaE);
            this.Controls.Add(this.lblFechaE);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.txtFechaS);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtIdRefaccion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblIdDepartamento);
            this.Controls.Add(this.lblFechaS);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblIdRefaccion);
            this.Controls.Add(this.lblAltaRefaccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizacionRefaccion";
            this.Text = "ActualizacionRefaccion";
            this.Load += new System.EventHandler(this.ActualizacionRefaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtFechaE;
        private System.Windows.Forms.Label lblFechaE;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtFechaS;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIdRefaccion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.Label lblFechaS;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblIdRefaccion;
        private System.Windows.Forms.Label lblAltaRefaccion;
        private System.Windows.Forms.DataGridView DataGActualizar;
        private System.Windows.Forms.Button btnGuardar;
    }
}