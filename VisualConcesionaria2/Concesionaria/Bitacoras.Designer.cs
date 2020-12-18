namespace Concesionaria
{
    partial class Bitacoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacoras));
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.btnAccesAlta = new System.Windows.Forms.Button();
            this.btnAutosAlta = new System.Windows.Forms.Button();
            this.btnEmpleadosAlta = new System.Windows.Forms.Button();
            this.btnClientesAlta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbMovimientos = new System.Windows.Forms.GroupBox();
            this.btnCompraBita = new System.Windows.Forms.Button();
            this.btnTraspasosBita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbMovimientos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1006, 467);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitacoras";
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.btnAccesAlta);
            this.gbRegistros.Controls.Add(this.btnAutosAlta);
            this.gbRegistros.Controls.Add(this.btnEmpleadosAlta);
            this.gbRegistros.Controls.Add(this.btnClientesAlta);
            this.gbRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRegistros.Location = new System.Drawing.Point(290, 69);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(493, 157);
            this.gbRegistros.TabIndex = 6;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros";
            // 
            // btnAccesAlta
            // 
            this.btnAccesAlta.BackColor = System.Drawing.Color.Teal;
            this.btnAccesAlta.ForeColor = System.Drawing.Color.White;
            this.btnAccesAlta.Location = new System.Drawing.Point(264, 68);
            this.btnAccesAlta.Name = "btnAccesAlta";
            this.btnAccesAlta.Size = new System.Drawing.Size(181, 38);
            this.btnAccesAlta.TabIndex = 3;
            this.btnAccesAlta.Text = "Accesorios";
            this.btnAccesAlta.UseVisualStyleBackColor = false;
            // 
            // btnAutosAlta
            // 
            this.btnAutosAlta.BackColor = System.Drawing.Color.Teal;
            this.btnAutosAlta.ForeColor = System.Drawing.Color.White;
            this.btnAutosAlta.Location = new System.Drawing.Point(264, 24);
            this.btnAutosAlta.Name = "btnAutosAlta";
            this.btnAutosAlta.Size = new System.Drawing.Size(181, 38);
            this.btnAutosAlta.TabIndex = 2;
            this.btnAutosAlta.Text = "Autos";
            this.btnAutosAlta.UseVisualStyleBackColor = false;
            // 
            // btnEmpleadosAlta
            // 
            this.btnEmpleadosAlta.BackColor = System.Drawing.Color.Teal;
            this.btnEmpleadosAlta.ForeColor = System.Drawing.Color.White;
            this.btnEmpleadosAlta.Location = new System.Drawing.Point(42, 68);
            this.btnEmpleadosAlta.Name = "btnEmpleadosAlta";
            this.btnEmpleadosAlta.Size = new System.Drawing.Size(161, 38);
            this.btnEmpleadosAlta.TabIndex = 1;
            this.btnEmpleadosAlta.Text = "Empleados";
            this.btnEmpleadosAlta.UseVisualStyleBackColor = false;
            // 
            // btnClientesAlta
            // 
            this.btnClientesAlta.BackColor = System.Drawing.Color.Teal;
            this.btnClientesAlta.ForeColor = System.Drawing.Color.White;
            this.btnClientesAlta.Location = new System.Drawing.Point(42, 24);
            this.btnClientesAlta.Name = "btnClientesAlta";
            this.btnClientesAlta.Size = new System.Drawing.Size(161, 38);
            this.btnClientesAlta.TabIndex = 0;
            this.btnClientesAlta.Text = "Clientes";
            this.btnClientesAlta.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol,
            this.Fecha,
            this.Accion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 469);
            this.dataGridView1.TabIndex = 5;
            // 
            // gbMovimientos
            // 
            this.gbMovimientos.Controls.Add(this.btnTraspasosBita);
            this.gbMovimientos.Controls.Add(this.btnCompraBita);
            this.gbMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMovimientos.Location = new System.Drawing.Point(16, 69);
            this.gbMovimientos.Name = "gbMovimientos";
            this.gbMovimientos.Size = new System.Drawing.Size(259, 157);
            this.gbMovimientos.TabIndex = 4;
            this.gbMovimientos.TabStop = false;
            this.gbMovimientos.Text = "Movimientos";
            // 
            // btnCompraBita
            // 
            this.btnCompraBita.BackColor = System.Drawing.Color.Teal;
            this.btnCompraBita.ForeColor = System.Drawing.Color.White;
            this.btnCompraBita.Location = new System.Drawing.Point(42, 38);
            this.btnCompraBita.Name = "btnCompraBita";
            this.btnCompraBita.Size = new System.Drawing.Size(168, 38);
            this.btnCompraBita.TabIndex = 0;
            this.btnCompraBita.Text = "Compra-Venta";
            this.btnCompraBita.UseVisualStyleBackColor = false;
            // 
            // btnTraspasosBita
            // 
            this.btnTraspasosBita.BackColor = System.Drawing.Color.Teal;
            this.btnTraspasosBita.ForeColor = System.Drawing.Color.White;
            this.btnTraspasosBita.Location = new System.Drawing.Point(42, 95);
            this.btnTraspasosBita.Name = "btnTraspasosBita";
            this.btnTraspasosBita.Size = new System.Drawing.Size(168, 38);
            this.btnTraspasosBita.TabIndex = 2;
            this.btnTraspasosBita.Text = "Traspasos";
            this.btnTraspasosBita.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 52);
            this.panel1.TabIndex = 7;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.MinimumWidth = 6;
            this.Accion.Name = "Accion";
            this.Accion.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Location = new System.Drawing.Point(857, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 169);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 80);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 51);
            this.panel3.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.Maroon;
            this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipo.Location = new System.Drawing.Point(0, 51);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(200, 35);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "BITACORA";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bitacoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 738);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbMovimientos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bitacoras";
            this.Text = "Bitacoras";
            this.gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbMovimientos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.Button btnAccesAlta;
        private System.Windows.Forms.Button btnAutosAlta;
        private System.Windows.Forms.Button btnEmpleadosAlta;
        private System.Windows.Forms.Button btnClientesAlta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbMovimientos;
        private System.Windows.Forms.Button btnTraspasosBita;
        private System.Windows.Forms.Button btnCompraBita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTipo;
    }
}