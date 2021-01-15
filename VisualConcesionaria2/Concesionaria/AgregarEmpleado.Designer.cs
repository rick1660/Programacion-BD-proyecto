namespace Concesionaria
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.lblAutos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtFechaNa = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSeparador8 = new Concesionaria.txtSeparador();
            this.txtSeparador7 = new Concesionaria.txtSeparador();
            this.txtSeparador15 = new Concesionaria.txtSeparador();
            this.txtSeparador3 = new Concesionaria.txtSeparador();
            this.txtSeparador4 = new Concesionaria.txtSeparador();
            this.txtSeparador2 = new Concesionaria.txtSeparador();
            this.txtSeparador1 = new Concesionaria.txtSeparador();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(330, 27);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(232, 29);
            this.lblAutos.TabIndex = 15;
            this.lblAutos.Text = "Agregar Empleado";
            this.lblAutos.Click += new System.EventHandler(this.lblAutos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(650, 479);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 42);
            this.btnLimpiar.TabIndex = 166;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Teal;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(307, 461);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(293, 42);
            this.btnIngresar.TabIndex = 165;
            this.btnIngresar.Text = "Agregar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaIngreso.Location = new System.Drawing.Point(304, 330);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(293, 16);
            this.txtFechaIngreso.TabIndex = 163;
            this.txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
            this.txtFechaIngreso.Enter += new System.EventHandler(this.txtFechaIngreso_Enter);
            this.txtFechaIngreso.Leave += new System.EventHandler(this.txtFechaIngreso_Leave);
            // 
            // txtFechaNa
            // 
            this.txtFechaNa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNa.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaNa.Location = new System.Drawing.Point(307, 292);
            this.txtFechaNa.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNa.Name = "txtFechaNa";
            this.txtFechaNa.Size = new System.Drawing.Size(293, 16);
            this.txtFechaNa.TabIndex = 162;
            this.txtFechaNa.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
            this.txtFechaNa.Enter += new System.EventHandler(this.txtFechaNa_Enter);
            this.txtFechaNa.Leave += new System.EventHandler(this.txtFechaNa_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(307, 254);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(293, 16);
            this.txtPassword.TabIndex = 161;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(307, 214);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(293, 16);
            this.txtCorreo.TabIndex = 160;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.textCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Gray;
            this.txtTel.Location = new System.Drawing.Point(304, 366);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(293, 16);
            this.txtTel.TabIndex = 164;
            this.txtTel.Text = "Telefono";
            this.txtTel.Enter += new System.EventHandler(this.textTel_Enter);
            this.txtTel.Leave += new System.EventHandler(this.textTel_Leave);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.Location = new System.Drawing.Point(307, 178);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(293, 16);
            this.txtApellidos.TabIndex = 159;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(307, 145);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 16);
            this.txtNombre.TabIndex = 158;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtSeparador8
            // 
            this.txtSeparador8.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador8.Location = new System.Drawing.Point(304, 347);
            this.txtSeparador8.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador8.Name = "txtSeparador8";
            this.txtSeparador8.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador8.TabIndex = 174;
            this.txtSeparador8.Text = "txtSeparador8";
            // 
            // txtSeparador7
            // 
            this.txtSeparador7.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador7.Location = new System.Drawing.Point(307, 309);
            this.txtSeparador7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador7.Name = "txtSeparador7";
            this.txtSeparador7.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador7.TabIndex = 173;
            this.txtSeparador7.Text = "txtSeparador7";
            // 
            // txtSeparador15
            // 
            this.txtSeparador15.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador15.Location = new System.Drawing.Point(307, 270);
            this.txtSeparador15.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador15.Name = "txtSeparador15";
            this.txtSeparador15.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador15.TabIndex = 172;
            this.txtSeparador15.Text = "txtSeparador15";
            // 
            // txtSeparador3
            // 
            this.txtSeparador3.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador3.Location = new System.Drawing.Point(307, 232);
            this.txtSeparador3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador3.Name = "txtSeparador3";
            this.txtSeparador3.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador3.TabIndex = 171;
            this.txtSeparador3.Text = "txtSeparador3";
            // 
            // txtSeparador4
            // 
            this.txtSeparador4.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador4.Location = new System.Drawing.Point(304, 383);
            this.txtSeparador4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador4.Name = "txtSeparador4";
            this.txtSeparador4.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador4.TabIndex = 170;
            this.txtSeparador4.Text = "txtSeparador4";
            // 
            // txtSeparador2
            // 
            this.txtSeparador2.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador2.Location = new System.Drawing.Point(307, 194);
            this.txtSeparador2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador2.Name = "txtSeparador2";
            this.txtSeparador2.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador2.TabIndex = 169;
            this.txtSeparador2.Text = "txtSeparador2";
            // 
            // txtSeparador1
            // 
            this.txtSeparador1.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador1.Location = new System.Drawing.Point(307, 162);
            this.txtSeparador1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador1.Name = "txtSeparador1";
            this.txtSeparador1.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador1.TabIndex = 168;
            this.txtSeparador1.Text = "txtSeparador1";
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtSeparador8);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtSeparador7);
            this.Controls.Add(this.txtFechaNa);
            this.Controls.Add(this.txtSeparador15);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSeparador3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtSeparador4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSeparador2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtSeparador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnIngresar;
        private txtSeparador txtSeparador8;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private txtSeparador txtSeparador7;
        private System.Windows.Forms.TextBox txtFechaNa;
        private txtSeparador txtSeparador15;
        private System.Windows.Forms.TextBox txtPassword;
        private txtSeparador txtSeparador3;
        private System.Windows.Forms.TextBox txtCorreo;
        private txtSeparador txtSeparador4;
        private System.Windows.Forms.TextBox txtTel;
        private txtSeparador txtSeparador2;
        private System.Windows.Forms.TextBox txtApellidos;
        private txtSeparador txtSeparador1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}