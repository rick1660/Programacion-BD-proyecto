namespace ProyectoBD
{
    partial class AltaRefaccion
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtFechaE = new System.Windows.Forms.TextBox();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtFechaS = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIdRefaccion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.lblFechaS = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblIdRefaccion = new System.Windows.Forms.Label();
            this.lblAltaRefaccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGAlta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 22);
            this.txtNombre.TabIndex = 49;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtFechaE
            // 
            this.txtFechaE.Location = new System.Drawing.Point(529, 107);
            this.txtFechaE.Name = "txtFechaE";
            this.txtFechaE.Size = new System.Drawing.Size(180, 22);
            this.txtFechaE.TabIndex = 47;
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaE.Location = new System.Drawing.Point(384, 107);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(135, 32);
            this.lblFechaE.TabIndex = 46;
            this.lblFechaE.Text = "Fecha de Entrada:\r\n(DD-MM-AA)";
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(552, 210);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(157, 22);
            this.txtDepart.TabIndex = 44;
            // 
            // txtFechaS
            // 
            this.txtFechaS.Location = new System.Drawing.Point(529, 168);
            this.txtFechaS.Name = "txtFechaS";
            this.txtFechaS.Size = new System.Drawing.Size(180, 22);
            this.txtFechaS.TabIndex = 43;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(135, 198);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(114, 22);
            this.txtCosto.TabIndex = 41;
            // 
            // txtIdRefaccion
            // 
            this.txtIdRefaccion.Location = new System.Drawing.Point(188, 101);
            this.txtIdRefaccion.Name = "txtIdRefaccion";
            this.txtIdRefaccion.Size = new System.Drawing.Size(156, 22);
            this.txtIdRefaccion.TabIndex = 40;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(280, 513);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(253, 34);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDepartamento.Location = new System.Drawing.Point(384, 216);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(111, 16);
            this.lblIdDepartamento.TabIndex = 37;
            this.lblIdDepartamento.Text = "Departamento:";
            // 
            // lblFechaS
            // 
            this.lblFechaS.AutoSize = true;
            this.lblFechaS.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaS.Location = new System.Drawing.Point(384, 158);
            this.lblFechaS.Name = "lblFechaS";
            this.lblFechaS.Size = new System.Drawing.Size(119, 32);
            this.lblFechaS.TabIndex = 36;
            this.lblFechaS.Text = "Fecha de Salida\r\n(DD-MM-AA)";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(44, 201);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(53, 16);
            this.lblCosto.TabIndex = 35;
            this.lblCosto.Text = "Costo:";
            // 
            // lblIdRefaccion
            // 
            this.lblIdRefaccion.AutoSize = true;
            this.lblIdRefaccion.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRefaccion.Location = new System.Drawing.Point(44, 104);
            this.lblIdRefaccion.Name = "lblIdRefaccion";
            this.lblIdRefaccion.Size = new System.Drawing.Size(122, 16);
            this.lblIdRefaccion.TabIndex = 34;
            this.lblIdRefaccion.Text = "ID de Refaccion:";
            // 
            // lblAltaRefaccion
            // 
            this.lblAltaRefaccion.AutoSize = true;
            this.lblAltaRefaccion.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaRefaccion.Location = new System.Drawing.Point(260, 9);
            this.lblAltaRefaccion.Name = "lblAltaRefaccion";
            this.lblAltaRefaccion.Size = new System.Drawing.Size(300, 38);
            this.lblAltaRefaccion.TabIndex = 33;
            this.lblAltaRefaccion.Text = "ALTA REFACCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "$";
            // 
            // DataGAlta
            // 
            this.DataGAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGAlta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGAlta.Location = new System.Drawing.Point(26, 263);
            this.DataGAlta.Name = "DataGAlta";
            this.DataGAlta.RowHeadersWidth = 51;
            this.DataGAlta.RowTemplate.Height = 24;
            this.DataGAlta.Size = new System.Drawing.Size(734, 244);
            this.DataGAlta.TabIndex = 51;
            // 
            // AltaRefaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.DataGAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFechaE);
            this.Controls.Add(this.lblFechaE);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.txtFechaS);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtIdRefaccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIdDepartamento);
            this.Controls.Add(this.lblFechaS);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblIdRefaccion);
            this.Controls.Add(this.lblAltaRefaccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaRefaccion";
            this.Text = "AltaRefaccion";
            this.Load += new System.EventHandler(this.AltaRefaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtFechaE;
        private System.Windows.Forms.Label lblFechaE;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtFechaS;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIdRefaccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.Label lblFechaS;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblIdRefaccion;
        private System.Windows.Forms.Label lblAltaRefaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGAlta;
    }
}