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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtSeparador2 = new Concesionaria.txtSeparador();
            this.txtSeparador1 = new Concesionaria.txtSeparador();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelSuperior.Controls.Add(this.ptxMinimizar);
            this.PanelSuperior.Controls.Add(this.ptxCerrar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(593, 37);
            this.PanelSuperior.TabIndex = 0;
            // 
            // ptxMinimizar
            // 
            this.ptxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptxMinimizar.Image")));
            this.ptxMinimizar.Location = new System.Drawing.Point(544, 8);
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
            this.ptxCerrar.Location = new System.Drawing.Point(570, 8);
            this.ptxCerrar.Name = "ptxCerrar";
            this.ptxCerrar.Size = new System.Drawing.Size(20, 20);
            this.ptxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxCerrar.TabIndex = 5;
            this.ptxCerrar.TabStop = false;
            this.ptxCerrar.Click += new System.EventHandler(this.ptxCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 338);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "INICIO DE SESION";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Location = new System.Drawing.Point(73, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 13);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "USUARIO";
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(236, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 338);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.Location = new System.Drawing.Point(141, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrarte";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Crimson;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.Location = new System.Drawing.Point(107, 241);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(122, 37);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Location = new System.Drawing.Point(73, 196);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 13);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.Text = "CONTRASEÑA";
            // 
            // txtSeparador2
            // 
            this.txtSeparador2.ForeColor = System.Drawing.Color.Red;
            this.txtSeparador2.Location = new System.Drawing.Point(73, 207);
            this.txtSeparador2.Name = "txtSeparador2";
            this.txtSeparador2.Size = new System.Drawing.Size(220, 2);
            this.txtSeparador2.TabIndex = 13;
            this.txtSeparador2.Text = "txtSeparador2";
            // 
            // txtSeparador1
            // 
            this.txtSeparador1.ForeColor = System.Drawing.Color.Red;
            this.txtSeparador1.Location = new System.Drawing.Point(73, 135);
            this.txtSeparador1.Name = "txtSeparador1";
            this.txtSeparador1.Size = new System.Drawing.Size(220, 2);
            this.txtSeparador1.TabIndex = 10;
            this.txtSeparador1.Text = "txtSeparador1";
            this.txtSeparador1.Click += new System.EventHandler(this.txtSeparador1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox ptxMinimizar;
        private System.Windows.Forms.PictureBox ptxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnIniciar;
        private txtSeparador txtSeparador1;
        private txtSeparador txtSeparador2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}