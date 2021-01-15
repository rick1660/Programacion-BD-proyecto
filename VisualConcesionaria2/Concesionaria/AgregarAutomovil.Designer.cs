namespace Concesionaria
{
    partial class AgregarAutomovil
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
            this.components = new System.ComponentModel.Container();
            this.txtSeparador5 = new Concesionaria.txtSeparador();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSeparador6 = new Concesionaria.txtSeparador();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtSeparador9 = new Concesionaria.txtSeparador();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtSeparador10 = new Concesionaria.txtSeparador();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtSeparador11 = new Concesionaria.txtSeparador();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtSeparador12 = new Concesionaria.txtSeparador();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtSeparador13 = new Concesionaria.txtSeparador();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSeparador14 = new Concesionaria.txtSeparador();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeparador5
            // 
            this.txtSeparador5.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador5.Location = new System.Drawing.Point(269, 369);
            this.txtSeparador5.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador5.Name = "txtSeparador5";
            this.txtSeparador5.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador5.TabIndex = 175;
            this.txtSeparador5.Text = "txtSeparador5";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecioVenta.Location = new System.Drawing.Point(269, 352);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(293, 16);
            this.txtPrecioVenta.TabIndex = 8;
            this.txtPrecioVenta.Text = "Precio venta";
            this.txtPrecioVenta.Enter += new System.EventHandler(this.txtPrecioVenta_Enter);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(609, 426);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(266, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSeparador6
            // 
            this.txtSeparador6.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador6.Location = new System.Drawing.Point(269, 291);
            this.txtSeparador6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador6.Name = "txtSeparador6";
            this.txtSeparador6.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador6.TabIndex = 173;
            this.txtSeparador6.Text = "txtSeparador6";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaIngreso.Location = new System.Drawing.Point(269, 274);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(293, 16);
            this.txtFechaIngreso.TabIndex = 6;
            this.txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
            this.txtFechaIngreso.Enter += new System.EventHandler(this.txtFechaIngreso_Enter);
            this.txtFechaIngreso.Leave += new System.EventHandler(this.txtFechaIngreso_Leave);
            // 
            // txtSeparador9
            // 
            this.txtSeparador9.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador9.Location = new System.Drawing.Point(269, 254);
            this.txtSeparador9.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador9.Name = "txtSeparador9";
            this.txtSeparador9.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador9.TabIndex = 172;
            this.txtSeparador9.Text = "txtSeparador9";
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.Gray;
            this.txtSerie.Location = new System.Drawing.Point(269, 237);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(293, 16);
            this.txtSerie.TabIndex = 5;
            this.txtSerie.Text = "Serie";
            this.txtSerie.Enter += new System.EventHandler(this.txtSerie_Enter);
            this.txtSerie.Leave += new System.EventHandler(this.txtSerie_Leave);
            // 
            // txtSeparador10
            // 
            this.txtSeparador10.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador10.Location = new System.Drawing.Point(269, 215);
            this.txtSeparador10.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador10.Name = "txtSeparador10";
            this.txtSeparador10.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador10.TabIndex = 171;
            this.txtSeparador10.Text = "txtSeparador10";
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.Color.Gray;
            this.txtAño.Location = new System.Drawing.Point(269, 199);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(293, 16);
            this.txtAño.TabIndex = 4;
            this.txtAño.Text = "Año";
            this.txtAño.Enter += new System.EventHandler(this.txtAño_Enter);
            this.txtAño.Leave += new System.EventHandler(this.txtAño_Leave);
            // 
            // txtSeparador11
            // 
            this.txtSeparador11.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador11.Location = new System.Drawing.Point(269, 177);
            this.txtSeparador11.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador11.Name = "txtSeparador11";
            this.txtSeparador11.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador11.TabIndex = 170;
            this.txtSeparador11.Text = "txtSeparador11";
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Gray;
            this.txtColor.Location = new System.Drawing.Point(269, 159);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(293, 16);
            this.txtColor.TabIndex = 3;
            this.txtColor.Text = "Color";
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // txtSeparador12
            // 
            this.txtSeparador12.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador12.Location = new System.Drawing.Point(269, 327);
            this.txtSeparador12.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador12.Name = "txtSeparador12";
            this.txtSeparador12.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador12.TabIndex = 169;
            this.txtSeparador12.Text = "txtSeparador12";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecioCompra.Location = new System.Drawing.Point(269, 310);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(293, 16);
            this.txtPrecioCompra.TabIndex = 7;
            this.txtPrecioCompra.Text = "Precio de compra";
            this.txtPrecioCompra.Enter += new System.EventHandler(this.txtPrecioCompra_Enter);
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // txtSeparador13
            // 
            this.txtSeparador13.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador13.Location = new System.Drawing.Point(269, 139);
            this.txtSeparador13.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador13.Name = "txtSeparador13";
            this.txtSeparador13.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador13.TabIndex = 168;
            this.txtSeparador13.Text = "txtSeparador13";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.Gray;
            this.txtModelo.Location = new System.Drawing.Point(269, 123);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(293, 16);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.Text = "Modelo";
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtSeparador14
            // 
            this.txtSeparador14.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador14.Location = new System.Drawing.Point(269, 107);
            this.txtSeparador14.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador14.Name = "txtSeparador14";
            this.txtSeparador14.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador14.TabIndex = 167;
            this.txtSeparador14.Text = "txtSeparador14";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Gray;
            this.txtMarca.Location = new System.Drawing.Point(269, 90);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(293, 16);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Text = "Marca";
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(305, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 176;
            this.label1.Text = "Agregar Automovil";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregarAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeparador5);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSeparador6);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtSeparador9);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtSeparador10);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtSeparador11);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtSeparador12);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtSeparador13);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtSeparador14);
            this.Controls.Add(this.txtMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAutomovil";
            this.Text = "AgregarAutomovil";
            this.Load += new System.EventHandler(this.AgregarAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private txtSeparador txtSeparador5;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button2;
        private txtSeparador txtSeparador6;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private txtSeparador txtSeparador9;
        private System.Windows.Forms.TextBox txtSerie;
        private txtSeparador txtSeparador10;
        private System.Windows.Forms.TextBox txtAño;
        private txtSeparador txtSeparador11;
        private System.Windows.Forms.TextBox txtColor;
        private txtSeparador txtSeparador12;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private txtSeparador txtSeparador13;
        private System.Windows.Forms.TextBox txtModelo;
        private txtSeparador txtSeparador14;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}