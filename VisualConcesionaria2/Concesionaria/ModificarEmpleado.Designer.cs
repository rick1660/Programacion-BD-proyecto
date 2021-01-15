namespace Concesionaria
{
    partial class ModificarEmpleado
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
            this.lblAutos = new System.Windows.Forms.Label();
            this.dgbEmpleados = new System.Windows.Forms.DataGridView();
            this.txtSeparador8 = new Concesionaria.txtSeparador();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtSeparador7 = new Concesionaria.txtSeparador();
            this.txtFechaNa = new System.Windows.Forms.TextBox();
            this.txtSeparador15 = new Concesionaria.txtSeparador();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSeparador3 = new Concesionaria.txtSeparador();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtSeparador4 = new Concesionaria.txtSeparador();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSeparador2 = new Concesionaria.txtSeparador();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtSeparador1 = new Concesionaria.txtSeparador();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(292, 18);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(247, 29);
            this.lblAutos.TabIndex = 155;
            this.lblAutos.Text = "Modificar Empleado";
            this.lblAutos.Click += new System.EventHandler(this.lblAutos_Click);
            // 
            // dgbEmpleados
            // 
            this.dgbEmpleados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbEmpleados.Location = new System.Drawing.Point(-3, 50);
            this.dgbEmpleados.Name = "dgbEmpleados";
            this.dgbEmpleados.Size = new System.Drawing.Size(825, 178);
            this.dgbEmpleados.TabIndex = 156;
            // 
            // txtSeparador8
            // 
            this.txtSeparador8.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador8.Location = new System.Drawing.Point(258, 457);
            this.txtSeparador8.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador8.Name = "txtSeparador8";
            this.txtSeparador8.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador8.TabIndex = 172;
            this.txtSeparador8.Text = "txtSeparador8";
            this.txtSeparador8.Click += new System.EventHandler(this.txtSeparador8_Click);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaIngreso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaIngreso.Location = new System.Drawing.Point(258, 443);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(293, 16);
            this.txtFechaIngreso.TabIndex = 6;
            this.txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
            this.txtFechaIngreso.Enter += new System.EventHandler(this.txtFechaIngreso_Enter);
            this.txtFechaIngreso.Leave += new System.EventHandler(this.txtFechaIngreso_Leave);
            // 
            // txtSeparador7
            // 
            this.txtSeparador7.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador7.Location = new System.Drawing.Point(258, 419);
            this.txtSeparador7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador7.Name = "txtSeparador7";
            this.txtSeparador7.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador7.TabIndex = 171;
            this.txtSeparador7.Text = "txtSeparador7";
            // 
            // txtFechaNa
            // 
            this.txtFechaNa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNa.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaNa.Location = new System.Drawing.Point(258, 402);
            this.txtFechaNa.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNa.Name = "txtFechaNa";
            this.txtFechaNa.Size = new System.Drawing.Size(293, 16);
            this.txtFechaNa.TabIndex = 5;
            this.txtFechaNa.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
            this.txtFechaNa.TextChanged += new System.EventHandler(this.txtFechaNa_TextChanged);
            this.txtFechaNa.Enter += new System.EventHandler(this.txtFechaNa_Enter);
            this.txtFechaNa.Leave += new System.EventHandler(this.txtFechaNa_Leave);
            // 
            // txtSeparador15
            // 
            this.txtSeparador15.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador15.Location = new System.Drawing.Point(258, 380);
            this.txtSeparador15.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador15.Name = "txtSeparador15";
            this.txtSeparador15.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador15.TabIndex = 170;
            this.txtSeparador15.Text = "txtSeparador15";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(258, 364);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(293, 16);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtSeparador3
            // 
            this.txtSeparador3.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador3.Location = new System.Drawing.Point(258, 342);
            this.txtSeparador3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador3.Name = "txtSeparador3";
            this.txtSeparador3.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador3.TabIndex = 169;
            this.txtSeparador3.Text = "txtSeparador3";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(258, 324);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(293, 16);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.Enter += new System.EventHandler(this.textCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // txtSeparador4
            // 
            this.txtSeparador4.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador4.Location = new System.Drawing.Point(258, 494);
            this.txtSeparador4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador4.Name = "txtSeparador4";
            this.txtSeparador4.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador4.TabIndex = 168;
            this.txtSeparador4.Text = "txtSeparador4";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Gray;
            this.txtTel.Location = new System.Drawing.Point(258, 477);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(293, 16);
            this.txtTel.TabIndex = 7;
            this.txtTel.Text = "Telefono";
            this.txtTel.Enter += new System.EventHandler(this.textTel_Enter);
            this.txtTel.Leave += new System.EventHandler(this.textTel_Leave);
            // 
            // txtSeparador2
            // 
            this.txtSeparador2.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador2.Location = new System.Drawing.Point(258, 304);
            this.txtSeparador2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador2.Name = "txtSeparador2";
            this.txtSeparador2.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador2.TabIndex = 167;
            this.txtSeparador2.Text = "txtSeparador2";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.Location = new System.Drawing.Point(258, 288);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(293, 16);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // txtSeparador1
            // 
            this.txtSeparador1.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador1.Location = new System.Drawing.Point(258, 272);
            this.txtSeparador1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador1.Name = "txtSeparador1";
            this.txtSeparador1.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador1.TabIndex = 166;
            this.txtSeparador1.Text = "txtSeparador1";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(258, 255);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 16);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(406, 527);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 32);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Teal;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(229, 526);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(136, 33);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSeleccionar);
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
            this.Controls.Add(this.dgbEmpleados);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarEmpleado";
            this.Text = "ModificarEmpleado";
            this.Load += new System.EventHandler(this.ModificarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.DataGridView dgbEmpleados;
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}