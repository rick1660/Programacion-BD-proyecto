namespace ProyectoBD
{
    partial class AltaServicio
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
            this.txtIdServicio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdServicio = new System.Windows.Forms.Label();
            this.lblAltaServicio = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();
            this.lblIdDept = new System.Windows.Forms.Label();
            this.lblDiag = new System.Windows.Forms.Label();
            this.lblFinalG = new System.Windows.Forms.Label();
            this.lblInicioG = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.txtInicioG = new System.Windows.Forms.TextBox();
            this.txtFinalG = new System.Windows.Forms.TextBox();
            this.txtIdDiag = new System.Windows.Forms.TextBox();
            this.txtIdDepart = new System.Windows.Forms.TextBox();
            this.DataGAlta = new System.Windows.Forms.DataGridView();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.Location = new System.Drawing.Point(189, 84);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Size = new System.Drawing.Size(156, 22);
            this.txtIdServicio.TabIndex = 56;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(266, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(253, 34);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdServicio
            // 
            this.lblIdServicio.AutoSize = true;
            this.lblIdServicio.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdServicio.Location = new System.Drawing.Point(40, 84);
            this.lblIdServicio.Name = "lblIdServicio";
            this.lblIdServicio.Size = new System.Drawing.Size(110, 16);
            this.lblIdServicio.TabIndex = 52;
            this.lblIdServicio.Text = "ID de Servicio:";
            // 
            // lblAltaServicio
            // 
            this.lblAltaServicio.AutoSize = true;
            this.lblAltaServicio.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaServicio.Location = new System.Drawing.Point(284, 9);
            this.lblAltaServicio.Name = "lblAltaServicio";
            this.lblAltaServicio.Size = new System.Drawing.Size(264, 38);
            this.lblAltaServicio.TabIndex = 51;
            this.lblAltaServicio.Text = "ALTA SERVICIO";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(40, 117);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(53, 16);
            this.lblCosto.TabIndex = 64;
            this.lblCosto.Text = "Costo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(40, 155);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 16);
            this.lblFecha.TabIndex = 65;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 193);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 66;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromo.Location = new System.Drawing.Point(40, 231);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(87, 16);
            this.lblPromo.TabIndex = 67;
            this.lblPromo.Text = "Promocion:";
            // 
            // lblIdDept
            // 
            this.lblIdDept.AutoSize = true;
            this.lblIdDept.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDept.Location = new System.Drawing.Point(418, 193);
            this.lblIdDept.Name = "lblIdDept";
            this.lblIdDept.Size = new System.Drawing.Size(155, 16);
            this.lblIdDept.TabIndex = 71;
            this.lblIdDept.Text = "ID del Departamento:";
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.Location = new System.Drawing.Point(418, 155);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(139, 16);
            this.lblDiag.TabIndex = 70;
            this.lblDiag.Text = "ID del Diagnostico:";
            // 
            // lblFinalG
            // 
            this.lblFinalG.AutoSize = true;
            this.lblFinalG.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalG.Location = new System.Drawing.Point(418, 117);
            this.lblFinalG.Name = "lblFinalG";
            this.lblFinalG.Size = new System.Drawing.Size(147, 16);
            this.lblFinalG.TabIndex = 69;
            this.lblFinalG.Text = "Final de la Garantia:\r\n";
            // 
            // lblInicioG
            // 
            this.lblInicioG.AutoSize = true;
            this.lblInicioG.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioG.Location = new System.Drawing.Point(418, 84);
            this.lblInicioG.Name = "lblInicioG";
            this.lblInicioG.Size = new System.Drawing.Size(151, 16);
            this.lblInicioG.TabIndex = 68;
            this.lblInicioG.Text = "Inicio de la Garantia:\r\n";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(189, 114);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(111, 22);
            this.txtCosto.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "$";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(189, 152);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(156, 22);
            this.txtFecha.TabIndex = 74;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(189, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 22);
            this.txtNombre.TabIndex = 75;
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(189, 231);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(193, 22);
            this.txtPromo.TabIndex = 76;
            // 
            // txtInicioG
            // 
            this.txtInicioG.Location = new System.Drawing.Point(575, 81);
            this.txtInicioG.Name = "txtInicioG";
            this.txtInicioG.Size = new System.Drawing.Size(202, 22);
            this.txtInicioG.TabIndex = 77;
            // 
            // txtFinalG
            // 
            this.txtFinalG.Location = new System.Drawing.Point(575, 117);
            this.txtFinalG.Name = "txtFinalG";
            this.txtFinalG.Size = new System.Drawing.Size(202, 22);
            this.txtFinalG.TabIndex = 78;
            // 
            // txtIdDiag
            // 
            this.txtIdDiag.Location = new System.Drawing.Point(575, 155);
            this.txtIdDiag.Name = "txtIdDiag";
            this.txtIdDiag.Size = new System.Drawing.Size(130, 22);
            this.txtIdDiag.TabIndex = 79;
            // 
            // txtIdDepart
            // 
            this.txtIdDepart.Location = new System.Drawing.Point(579, 187);
            this.txtIdDepart.Name = "txtIdDepart";
            this.txtIdDepart.Size = new System.Drawing.Size(126, 22);
            this.txtIdDepart.TabIndex = 80;
            // 
            // DataGAlta
            // 
            this.DataGAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGAlta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGAlta.Location = new System.Drawing.Point(43, 263);
            this.DataGAlta.Name = "DataGAlta";
            this.DataGAlta.RowHeadersWidth = 51;
            this.DataGAlta.RowTemplate.Height = 24;
            this.DataGAlta.Size = new System.Drawing.Size(734, 244);
            this.DataGAlta.TabIndex = 81;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(575, 225);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(49, 22);
            this.txtCount.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Veces:";
            // 
            // AltaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGAlta);
            this.Controls.Add(this.txtIdDepart);
            this.Controls.Add(this.txtIdDiag);
            this.Controls.Add(this.txtFinalG);
            this.Controls.Add(this.txtInicioG);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblIdDept);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.lblFinalG);
            this.Controls.Add(this.lblInicioG);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIdServicio);
            this.Controls.Add(this.lblAltaServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaServicio";
            this.Text = "AltaServicio";
            this.Load += new System.EventHandler(this.AltaServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdServicio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdServicio;
        private System.Windows.Forms.Label lblAltaServicio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label lblIdDept;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblFinalG;
        private System.Windows.Forms.Label lblInicioG;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.TextBox txtInicioG;
        private System.Windows.Forms.TextBox txtFinalG;
        private System.Windows.Forms.TextBox txtIdDiag;
        private System.Windows.Forms.TextBox txtIdDepart;
        private System.Windows.Forms.DataGridView DataGAlta;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
    }
}