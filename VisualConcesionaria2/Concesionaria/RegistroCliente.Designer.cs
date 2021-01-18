namespace Concesionaria
{
    partial class RegistroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptxMinimizar = new System.Windows.Forms.PictureBox();
            this.ptxCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtReferencia1 = new System.Windows.Forms.TextBox();
            this.txtNumR1 = new System.Windows.Forms.TextBox();
            this.txtNumR2 = new System.Windows.Forms.TextBox();
            this.txtReferencia2 = new System.Windows.Forms.TextBox();
            this.txtNumR3 = new System.Windows.Forms.TextBox();
            this.txtReferencia3 = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmxGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtFechaNa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSeparador5 = new Concesionaria.txtSeparador();
            this.txtSeparador15 = new Concesionaria.txtSeparador();
            this.txtSeparador13 = new Concesionaria.txtSeparador();
            this.txtSeparador14 = new Concesionaria.txtSeparador();
            this.txtSeparador10 = new Concesionaria.txtSeparador();
            this.txtSeparador12 = new Concesionaria.txtSeparador();
            this.txtSeparador11 = new Concesionaria.txtSeparador();
            this.txtSeparador9 = new Concesionaria.txtSeparador();
            this.txtSeparador8 = new Concesionaria.txtSeparador();
            this.txtSeparador7 = new Concesionaria.txtSeparador();
            this.txtSeparador6 = new Concesionaria.txtSeparador();
            this.txtSeparador3 = new Concesionaria.txtSeparador();
            this.txtSeparador4 = new Concesionaria.txtSeparador();
            this.txtSeparador2 = new Concesionaria.txtSeparador();
            this.txtSeparador1 = new Concesionaria.txtSeparador();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.ptxMinimizar);
            this.panel1.Controls.Add(this.ptxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 52);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ptxMinimizar
            // 
            this.ptxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptxMinimizar.Image")));
            this.ptxMinimizar.Location = new System.Drawing.Point(781, 14);
            this.ptxMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.ptxMinimizar.Name = "ptxMinimizar";
            this.ptxMinimizar.Size = new System.Drawing.Size(27, 25);
            this.ptxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxMinimizar.TabIndex = 10;
            this.ptxMinimizar.TabStop = false;
            this.ptxMinimizar.Click += new System.EventHandler(this.ptxMinimizar_Click);
            // 
            // ptxCerrar
            // 
            this.ptxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptxCerrar.Image")));
            this.ptxCerrar.Location = new System.Drawing.Point(815, 14);
            this.ptxCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.ptxCerrar.Name = "ptxCerrar";
            this.ptxCerrar.Size = new System.Drawing.Size(27, 25);
            this.ptxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxCerrar.TabIndex = 9;
            this.ptxCerrar.TabStop = false;
            this.ptxCerrar.Click += new System.EventHandler(this.ptxCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(309, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de cliente";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.Location = new System.Drawing.Point(105, 222);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.MaxLength = 45;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(293, 16);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(105, 189);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 16);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(105, 327);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 45;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(293, 16);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Text = "Correo";
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            this.txtCorreo.Enter += new System.EventHandler(this.textCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Gray;
            this.txtTel.Location = new System.Drawing.Point(105, 292);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.MaxLength = 10;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(293, 16);
            this.txtTel.TabIndex = 4;
            this.txtTel.Text = "Telefono";
            this.txtTel.Enter += new System.EventHandler(this.textTel_Enter);
            this.txtTel.Leave += new System.EventHandler(this.textTel_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.Gray;
            this.txtEdad.Location = new System.Drawing.Point(105, 364);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(293, 16);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.Text = "Edad";
            this.txtEdad.Enter += new System.EventHandler(this.textEdad_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.textEdad_Leave);
            // 
            // txtRFC
            // 
            this.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.Gray;
            this.txtRFC.Location = new System.Drawing.Point(105, 512);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(293, 16);
            this.txtRFC.TabIndex = 10;
            this.txtRFC.Text = "RFC";
            this.txtRFC.Enter += new System.EventHandler(this.textRFC_Enter);
            this.txtRFC.Leave += new System.EventHandler(this.textRFC_Leave);
            // 
            // txtReferencia1
            // 
            this.txtReferencia1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferencia1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferencia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia1.ForeColor = System.Drawing.Color.Gray;
            this.txtReferencia1.Location = new System.Drawing.Point(496, 213);
            this.txtReferencia1.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia1.MaxLength = 45;
            this.txtReferencia1.Name = "txtReferencia1";
            this.txtReferencia1.Size = new System.Drawing.Size(293, 16);
            this.txtReferencia1.TabIndex = 11;
            this.txtReferencia1.Text = "Nombre";
            this.txtReferencia1.Enter += new System.EventHandler(this.textReferencia1_Enter);
            this.txtReferencia1.Leave += new System.EventHandler(this.textReferencia1_Leave);
            // 
            // txtNumR1
            // 
            this.txtNumR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumR1.ForeColor = System.Drawing.Color.Gray;
            this.txtNumR1.Location = new System.Drawing.Point(496, 248);
            this.txtNumR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumR1.MaxLength = 10;
            this.txtNumR1.Name = "txtNumR1";
            this.txtNumR1.Size = new System.Drawing.Size(293, 16);
            this.txtNumR1.TabIndex = 12;
            this.txtNumR1.Text = "Telefono";
            this.txtNumR1.Enter += new System.EventHandler(this.textNumR1_Enter);
            this.txtNumR1.Leave += new System.EventHandler(this.textNumR1_Leave);
            // 
            // txtNumR2
            // 
            this.txtNumR2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumR2.ForeColor = System.Drawing.Color.Gray;
            this.txtNumR2.Location = new System.Drawing.Point(496, 381);
            this.txtNumR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumR2.MaxLength = 10;
            this.txtNumR2.Name = "txtNumR2";
            this.txtNumR2.Size = new System.Drawing.Size(293, 16);
            this.txtNumR2.TabIndex = 14;
            this.txtNumR2.Text = "Telefono";
            this.txtNumR2.Enter += new System.EventHandler(this.textNumR2_Enter);
            this.txtNumR2.Leave += new System.EventHandler(this.textNumR2_Leave);
            // 
            // txtReferencia2
            // 
            this.txtReferencia2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferencia2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferencia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia2.ForeColor = System.Drawing.Color.Gray;
            this.txtReferencia2.Location = new System.Drawing.Point(496, 344);
            this.txtReferencia2.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia2.MaxLength = 45;
            this.txtReferencia2.Name = "txtReferencia2";
            this.txtReferencia2.Size = new System.Drawing.Size(293, 16);
            this.txtReferencia2.TabIndex = 13;
            this.txtReferencia2.Text = "Nombre";
            this.txtReferencia2.Enter += new System.EventHandler(this.textReferencia2_Enter);
            this.txtReferencia2.Leave += new System.EventHandler(this.textReferencia2_Leave);
            // 
            // txtNumR3
            // 
            this.txtNumR3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumR3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumR3.ForeColor = System.Drawing.Color.Gray;
            this.txtNumR3.Location = new System.Drawing.Point(487, 517);
            this.txtNumR3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumR3.MaxLength = 10;
            this.txtNumR3.Name = "txtNumR3";
            this.txtNumR3.Size = new System.Drawing.Size(293, 16);
            this.txtNumR3.TabIndex = 16;
            this.txtNumR3.Text = "Telefono";
            this.txtNumR3.Enter += new System.EventHandler(this.textNumR3_Enter);
            this.txtNumR3.Leave += new System.EventHandler(this.textNumR3_Leave);
            // 
            // txtReferencia3
            // 
            this.txtReferencia3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferencia3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferencia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia3.ForeColor = System.Drawing.Color.Gray;
            this.txtReferencia3.Location = new System.Drawing.Point(487, 482);
            this.txtReferencia3.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia3.MaxLength = 45;
            this.txtReferencia3.Name = "txtReferencia3";
            this.txtReferencia3.Size = new System.Drawing.Size(293, 16);
            this.txtReferencia3.TabIndex = 15;
            this.txtReferencia3.Text = "Nombre";
            this.txtReferencia3.Enter += new System.EventHandler(this.txtReferencia3_Enter);
            this.txtReferencia3.Leave += new System.EventHandler(this.txtReferencia3_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Teal;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(261, 581);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(293, 42);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "Registrar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(105, 258);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(293, 16);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // cmxGenero
            // 
            this.cmxGenero.FormattingEnabled = true;
            this.cmxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmxGenero.Location = new System.Drawing.Point(229, 443);
            this.cmxGenero.MaxLength = 9;
            this.cmxGenero.Name = "cmxGenero";
            this.cmxGenero.Size = new System.Drawing.Size(113, 24);
            this.cmxGenero.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(141, 446);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 17);
            this.lblGenero.TabIndex = 48;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // txtFechaNa
            // 
            this.txtFechaNa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNa.ForeColor = System.Drawing.Color.Gray;
            this.txtFechaNa.Location = new System.Drawing.Point(105, 482);
            this.txtFechaNa.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNa.MaxLength = 10;
            this.txtFechaNa.Name = "txtFechaNa";
            this.txtFechaNa.Size = new System.Drawing.Size(293, 16);
            this.txtFechaNa.TabIndex = 9;
            this.txtFechaNa.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
            this.txtFechaNa.Enter += new System.EventHandler(this.txtFechaNa_Enter);
            this.txtFechaNa.Leave += new System.EventHandler(this.txtFechaNa_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(175, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Datos personales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(548, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Datos de referencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(557, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Primera referencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(557, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Segunda referencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(548, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tercera referencia";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(676, 581);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 42);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Gray;
            this.txtDireccion.Location = new System.Drawing.Point(105, 408);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 45;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(293, 16);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txtSeparador5
            // 
            this.txtSeparador5.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador5.Location = new System.Drawing.Point(105, 427);
            this.txtSeparador5.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador5.Name = "txtSeparador5";
            this.txtSeparador5.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador5.TabIndex = 56;
            this.txtSeparador5.Text = "txtSeparador5";
            // 
            // txtSeparador15
            // 
            this.txtSeparador15.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador15.Location = new System.Drawing.Point(105, 274);
            this.txtSeparador15.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador15.Name = "txtSeparador15";
            this.txtSeparador15.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador15.TabIndex = 46;
            this.txtSeparador15.Text = "txtSeparador15";
            // 
            // txtSeparador13
            // 
            this.txtSeparador13.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador13.Location = new System.Drawing.Point(487, 533);
            this.txtSeparador13.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador13.Name = "txtSeparador13";
            this.txtSeparador13.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador13.TabIndex = 43;
            this.txtSeparador13.Text = "txtSeparador13";
            // 
            // txtSeparador14
            // 
            this.txtSeparador14.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador14.Location = new System.Drawing.Point(487, 498);
            this.txtSeparador14.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador14.Name = "txtSeparador14";
            this.txtSeparador14.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador14.TabIndex = 41;
            this.txtSeparador14.Text = "txtSeparador14";
            // 
            // txtSeparador10
            // 
            this.txtSeparador10.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador10.Location = new System.Drawing.Point(496, 397);
            this.txtSeparador10.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador10.Name = "txtSeparador10";
            this.txtSeparador10.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador10.TabIndex = 39;
            this.txtSeparador10.Text = "txtSeparador10";
            // 
            // txtSeparador12
            // 
            this.txtSeparador12.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador12.Location = new System.Drawing.Point(496, 360);
            this.txtSeparador12.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador12.Name = "txtSeparador12";
            this.txtSeparador12.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador12.TabIndex = 37;
            this.txtSeparador12.Text = "txtSeparador12";
            // 
            // txtSeparador11
            // 
            this.txtSeparador11.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador11.Location = new System.Drawing.Point(496, 263);
            this.txtSeparador11.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador11.Name = "txtSeparador11";
            this.txtSeparador11.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador11.TabIndex = 35;
            this.txtSeparador11.Text = "txtSeparador11";
            // 
            // txtSeparador9
            // 
            this.txtSeparador9.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador9.Location = new System.Drawing.Point(496, 229);
            this.txtSeparador9.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador9.Name = "txtSeparador9";
            this.txtSeparador9.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador9.TabIndex = 31;
            this.txtSeparador9.Text = "txtSeparador9";
            // 
            // txtSeparador8
            // 
            this.txtSeparador8.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador8.Location = new System.Drawing.Point(105, 528);
            this.txtSeparador8.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador8.Name = "txtSeparador8";
            this.txtSeparador8.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador8.TabIndex = 29;
            this.txtSeparador8.Text = "txtSeparador8";
            // 
            // txtSeparador7
            // 
            this.txtSeparador7.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador7.Location = new System.Drawing.Point(105, 499);
            this.txtSeparador7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador7.Name = "txtSeparador7";
            this.txtSeparador7.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador7.TabIndex = 27;
            this.txtSeparador7.Text = "txtSeparador7";
            // 
            // txtSeparador6
            // 
            this.txtSeparador6.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador6.Location = new System.Drawing.Point(105, 383);
            this.txtSeparador6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador6.Name = "txtSeparador6";
            this.txtSeparador6.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador6.TabIndex = 23;
            this.txtSeparador6.Text = "txtSeparador6";
            // 
            // txtSeparador3
            // 
            this.txtSeparador3.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador3.Location = new System.Drawing.Point(105, 345);
            this.txtSeparador3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador3.Name = "txtSeparador3";
            this.txtSeparador3.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador3.TabIndex = 21;
            this.txtSeparador3.Text = "txtSeparador3";
            // 
            // txtSeparador4
            // 
            this.txtSeparador4.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador4.Location = new System.Drawing.Point(105, 309);
            this.txtSeparador4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador4.Name = "txtSeparador4";
            this.txtSeparador4.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador4.TabIndex = 19;
            this.txtSeparador4.Text = "txtSeparador4";
            // 
            // txtSeparador2
            // 
            this.txtSeparador2.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador2.Location = new System.Drawing.Point(105, 238);
            this.txtSeparador2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador2.Name = "txtSeparador2";
            this.txtSeparador2.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador2.TabIndex = 17;
            this.txtSeparador2.Text = "txtSeparador2";
            // 
            // txtSeparador1
            // 
            this.txtSeparador1.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador1.Location = new System.Drawing.Point(105, 206);
            this.txtSeparador1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeparador1.Name = "txtSeparador1";
            this.txtSeparador1.Size = new System.Drawing.Size(293, 2);
            this.txtSeparador1.TabIndex = 15;
            this.txtSeparador1.Text = "txtSeparador1";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.BackgroundImage = global::Concesionaria.Properties.Resources.arrow_123_128;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(29, 76);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(84, 42);
            this.btnRegresar.TabIndex = 57;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 650);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtSeparador5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmxGenero);
            this.Controls.Add(this.txtSeparador15);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtSeparador13);
            this.Controls.Add(this.txtNumR3);
            this.Controls.Add(this.txtSeparador14);
            this.Controls.Add(this.txtReferencia3);
            this.Controls.Add(this.txtSeparador10);
            this.Controls.Add(this.txtNumR2);
            this.Controls.Add(this.txtSeparador12);
            this.Controls.Add(this.txtReferencia2);
            this.Controls.Add(this.txtSeparador11);
            this.Controls.Add(this.txtNumR1);
            this.Controls.Add(this.txtSeparador9);
            this.Controls.Add(this.txtReferencia1);
            this.Controls.Add(this.txtSeparador8);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtSeparador7);
            this.Controls.Add(this.txtFechaNa);
            this.Controls.Add(this.txtSeparador6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSeparador3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtSeparador4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSeparador2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtSeparador1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.Shown += new System.EventHandler(this.RegistroCliente_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptxMinimizar;
        private System.Windows.Forms.PictureBox ptxCerrar;
        private System.Windows.Forms.Label label1;
        private txtSeparador txtSeparador2;
        private System.Windows.Forms.TextBox txtApellidos;
        private txtSeparador txtSeparador1;
        private System.Windows.Forms.TextBox txtNombre;
        private txtSeparador txtSeparador3;
        private System.Windows.Forms.TextBox txtCorreo;
        private txtSeparador txtSeparador4;
        private System.Windows.Forms.TextBox txtTel;
        private txtSeparador txtSeparador6;
        private System.Windows.Forms.TextBox txtEdad;
        private txtSeparador txtSeparador8;
        private System.Windows.Forms.TextBox txtRFC;
        private txtSeparador txtSeparador9;
        private System.Windows.Forms.TextBox txtReferencia1;
        private txtSeparador txtSeparador11;
        private System.Windows.Forms.TextBox txtNumR1;
        private txtSeparador txtSeparador10;
        private System.Windows.Forms.TextBox txtNumR2;
        private txtSeparador txtSeparador12;
        private System.Windows.Forms.TextBox txtReferencia2;
        private txtSeparador txtSeparador13;
        private System.Windows.Forms.TextBox txtNumR3;
        private txtSeparador txtSeparador14;
        private System.Windows.Forms.TextBox txtReferencia3;
        private System.Windows.Forms.Button btnIngresar;
        private txtSeparador txtSeparador15;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmxGenero;
        private System.Windows.Forms.Label lblGenero;
        private txtSeparador txtSeparador7;
        private System.Windows.Forms.TextBox txtFechaNa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private txtSeparador txtSeparador5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnRegresar;
    }
}