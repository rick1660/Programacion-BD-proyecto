namespace Concesionaria
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.ptxMinimizar = new System.Windows.Forms.PictureBox();
            this.ptxCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSeparador2 = new Concesionaria.txtSeparador();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtSeparador1 = new Concesionaria.txtSeparador();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.Teal;
            this.PanelSuperior.Controls.Add(this.ptxMinimizar);
            this.PanelSuperior.Controls.Add(this.ptxCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(485, 37);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // ptxMinimizar
            // 
            this.ptxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptxMinimizar.Image")));
            this.ptxMinimizar.Location = new System.Drawing.Point(436, 8);
            this.ptxMinimizar.Name = "ptxMinimizar";
            this.ptxMinimizar.Size = new System.Drawing.Size(20, 20);
            this.ptxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxMinimizar.TabIndex = 8;
            this.ptxMinimizar.TabStop = false;
            this.ptxMinimizar.Click += new System.EventHandler(this.ptxMinimizar_Click);
            // 
            // ptxCerrar
            // 
            this.ptxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptxCerrar.Image")));
            this.ptxCerrar.Location = new System.Drawing.Point(462, 8);
            this.ptxCerrar.Name = "ptxCerrar";
            this.ptxCerrar.Size = new System.Drawing.Size(20, 20);
            this.ptxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxCerrar.TabIndex = 5;
            this.ptxCerrar.TabStop = false;
            this.ptxCerrar.Click += new System.EventHandler(this.ptxCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "INICIO DE SESION";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(136, 112);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 19);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Tag = "";
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSeparador2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.txtSeparador1);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 393);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtSeparador2
            // 
            this.txtSeparador2.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador2.Location = new System.Drawing.Point(136, 207);
            this.txtSeparador2.Name = "txtSeparador2";
            this.txtSeparador2.Size = new System.Drawing.Size(220, 2);
            this.txtSeparador2.TabIndex = 13;
            this.txtSeparador2.Text = "txtSeparador2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(136, 190);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 19);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtSeparador1
            // 
            this.txtSeparador1.ForeColor = System.Drawing.Color.Teal;
            this.txtSeparador1.Location = new System.Drawing.Point(136, 129);
            this.txtSeparador1.Name = "txtSeparador1";
            this.txtSeparador1.Size = new System.Drawing.Size(220, 2);
            this.txtSeparador1.TabIndex = 10;
            this.txtSeparador1.Text = "txtSeparador1";
            this.txtSeparador1.Click += new System.EventHandler(this.txtSeparador1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Teal;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(136, 235);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(220, 37);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(171)))), ((int)(((byte)(190)))));
            this.linkLabel1.Location = new System.Drawing.Point(218, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrarte";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 142);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(97, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox ptxMinimizar;
        private System.Windows.Forms.PictureBox ptxCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnIniciar;
        private txtSeparador txtSeparador1;
        private txtSeparador txtSeparador2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}