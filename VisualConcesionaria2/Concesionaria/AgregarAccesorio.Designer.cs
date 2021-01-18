namespace Concesionaria
{
    partial class AgregarAccesorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAccesorio));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtSeparador15 = new Concesionaria.txtSeparador();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtSeparador2 = new Concesionaria.txtSeparador();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSeparador1 = new Concesionaria.txtSeparador();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAutos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSeparador3 = new Concesionaria.txtSeparador();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(611, 487);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 42);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Teal;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(268, 363);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(293, 42);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Agregar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtSeparador15
            // 
            this.txtSeparador15.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador15.Location = new System.Drawing.Point(268, 333);
            this.txtSeparador15.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador15.Name = "txtSeparador15";
            this.txtSeparador15.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador15.TabIndex = 189;
            this.txtSeparador15.Text = "txtSeparador15";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gray;
            this.txtCantidad.Location = new System.Drawing.Point(268, 317);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(293, 16);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.Text = "Cantidad";
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtSeparador2
            // 
            this.txtSeparador2.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador2.Location = new System.Drawing.Point(268, 257);
            this.txtSeparador2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador2.Name = "txtSeparador2";
            this.txtSeparador2.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador2.TabIndex = 186;
            this.txtSeparador2.Text = "txtSeparador2";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.Gray;
            this.txtModelo.Location = new System.Drawing.Point(268, 241);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(293, 16);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.Text = "Modelo";
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtSeparador1
            // 
            this.txtSeparador1.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador1.Location = new System.Drawing.Point(268, 225);
            this.txtSeparador1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador1.Name = "txtSeparador1";
            this.txtSeparador1.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador1.TabIndex = 185;
            this.txtSeparador1.Text = "txtSeparador1";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(268, 208);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 16);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(302, 42);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(229, 29);
            this.lblAutos.TabIndex = 175;
            this.lblAutos.Text = "Agregar Accesorio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // txtSeparador3
            // 
            this.txtSeparador3.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador3.Location = new System.Drawing.Point(268, 295);
            this.txtSeparador3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador3.Name = "txtSeparador3";
            this.txtSeparador3.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador3.TabIndex = 191;
            this.txtSeparador3.Text = "txtSeparador3";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecio.Location = new System.Drawing.Point(268, 279);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(293, 16);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.Text = "Precio";
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // AgregarAccesorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.txtSeparador3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtSeparador15);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtSeparador2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtSeparador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarAccesorio";
            this.Text = "AgregarAccesorio";
            this.Load += new System.EventHandler(this.AgregarAccesorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnIngresar;
        private txtSeparador txtSeparador15;
        private System.Windows.Forms.TextBox txtCantidad;
        private txtSeparador txtSeparador2;
        private System.Windows.Forms.TextBox txtModelo;
        private txtSeparador txtSeparador1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private txtSeparador txtSeparador3;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}