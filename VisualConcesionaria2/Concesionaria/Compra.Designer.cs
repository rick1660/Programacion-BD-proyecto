namespace Concesionaria
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtDocIdentidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusquedaProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Automovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accesorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promocion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 42);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(185, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Registro";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 23);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Venta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Compra";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(246, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Compra:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBusqueda);
            this.groupBox3.Controls.Add(this.txtDocIdentidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDatos);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 82);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(294, 22);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(93, 23);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtDocIdentidad
            // 
            this.txtDocIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocIdentidad.Location = new System.Drawing.Point(116, 23);
            this.txtDocIdentidad.Name = "txtDocIdentidad";
            this.txtDocIdentidad.ReadOnly = true;
            this.txtDocIdentidad.Size = new System.Drawing.Size(172, 21);
            this.txtDocIdentidad.TabIndex = 3;
            this.txtDocIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id. Cliente";
            // 
            // txtDatos
            // 
            this.txtDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatos.Location = new System.Drawing.Point(82, 50);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.Size = new System.Drawing.Size(306, 21);
            this.txtDatos.TabIndex = 1;
            this.txtDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnBusquedaProducto);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtPVenta);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtMarca);
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 92);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(385, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modelo:";
            // 
            // btnBusquedaProducto
            // 
            this.btnBusquedaProducto.Location = new System.Drawing.Point(535, 23);
            this.btnBusquedaProducto.Name = "btnBusquedaProducto";
            this.btnBusquedaProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBusquedaProducto.TabIndex = 11;
            this.btnBusquedaProducto.Text = "Buscar";
            this.btnBusquedaProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(524, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(225, 58);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(69, 21);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cantidad:";
            // 
            // txtPVenta
            // 
            this.txtPVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPVenta.Location = new System.Drawing.Point(74, 58);
            this.txtPVenta.Name = "txtPVenta";
            this.txtPVenta.ReadOnly = true;
            this.txtPVenta.Size = new System.Drawing.Size(75, 21);
            this.txtPVenta.TabIndex = 7;
            this.txtPVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "P. Venta:";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Location = new System.Drawing.Point(385, 24);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(134, 21);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(93, 24);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(205, 21);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descripción:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Automovil,
            this.Accesorio,
            this.Cantidad,
            this.Precio,
            this.Promocion,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(10, 353);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 198);
            this.dataGridView1.TabIndex = 12;
            // 
            // Automovil
            // 
            this.Automovil.HeaderText = "Automovil";
            this.Automovil.MinimumWidth = 6;
            this.Automovil.Name = "Automovil";
            this.Automovil.Width = 125;
            // 
            // Accesorio
            // 
            this.Accesorio.HeaderText = "Accesorio";
            this.Accesorio.MinimumWidth = 6;
            this.Accesorio.Name = "Accesorio";
            this.Accesorio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Promocion
            // 
            this.Promocion.HeaderText = "Promocion";
            this.Promocion.MinimumWidth = 6;
            this.Promocion.Name = "Promocion";
            this.Promocion.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Location = new System.Drawing.Point(517, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 137);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 65);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 42);
            this.panel3.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.Teal;
            this.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(0, 41);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(150, 29);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "COMPRA";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Location = new System.Drawing.Point(346, 566);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(196, 25);
            this.btnRegistrarVenta.TabIndex = 21;
            this.btnRegistrarVenta.Text = "&Registrar Compra-Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(558, 566);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 25);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 601);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.Text = "Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtDocIdentidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBusquedaProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accesorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promocion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnSalir;
    }
}