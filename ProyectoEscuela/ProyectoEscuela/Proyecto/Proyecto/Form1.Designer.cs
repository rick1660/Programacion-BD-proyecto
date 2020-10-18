namespace Proyecto
{
    partial class Froma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Froma));
            this.PanelBar = new System.Windows.Forms.Panel();
            this.PicMIn = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.PanelMV = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnMaestra = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKardex = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelP = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.PanelMV.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.Black;
            this.PanelBar.Controls.Add(this.PicMIn);
            this.PanelBar.Controls.Add(this.PicClose);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(1343, 37);
            this.PanelBar.TabIndex = 1;
            this.PanelBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.PanelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // PicMIn
            // 
            this.PicMIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMIn.Image = ((System.Drawing.Image)(resources.GetObject("PicMIn.Image")));
            this.PicMIn.Location = new System.Drawing.Point(1279, 5);
            this.PicMIn.Margin = new System.Windows.Forms.Padding(4);
            this.PicMIn.Name = "PicMIn";
            this.PicMIn.Size = new System.Drawing.Size(25, 25);
            this.PicMIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMIn.TabIndex = 2;
            this.PicMIn.TabStop = false;
            this.PicMIn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PicClose
            // 
            this.PicClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = ((System.Drawing.Image)(resources.GetObject("PicClose.Image")));
            this.PicClose.Location = new System.Drawing.Point(1305, 2);
            this.PicClose.Margin = new System.Windows.Forms.Padding(4);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(33, 31);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 0;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelMV
            // 
            this.PanelMV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelMV.Controls.Add(this.btnIniciar);
            this.PanelMV.Controls.Add(this.btnMaestra);
            this.PanelMV.Controls.Add(this.btnConsulta);
            this.PanelMV.Controls.Add(this.panel6);
            this.PanelMV.Controls.Add(this.button1);
            this.PanelMV.Controls.Add(this.panel3);
            this.PanelMV.Controls.Add(this.btnHistorial);
            this.PanelMV.Controls.Add(this.panel2);
            this.PanelMV.Controls.Add(this.btnKardex);
            this.PanelMV.Controls.Add(this.panel1);
            this.PanelMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMV.Location = new System.Drawing.Point(0, 37);
            this.PanelMV.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMV.Name = "PanelMV";
            this.PanelMV.Size = new System.Drawing.Size(197, 668);
            this.PanelMV.TabIndex = 2;
            this.PanelMV.Visible = false;
            this.PanelMV.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMV_Paint);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Image = global::Proyecto.Properties.Resources.home___1391_;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(16, 107);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(165, 69);
            this.btnIniciar.TabIndex = 21;
            this.btnIniciar.Text = "Inicio";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // btnMaestra
            // 
            this.btnMaestra.BackColor = System.Drawing.Color.Transparent;
            this.btnMaestra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaestra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnMaestra.FlatAppearance.BorderSize = 0;
            this.btnMaestra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnMaestra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnMaestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaestra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaestra.Image = global::Proyecto.Properties.Resources.fileboard___1801_;
            this.btnMaestra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaestra.Location = new System.Drawing.Point(16, 336);
            this.btnMaestra.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaestra.Name = "btnMaestra";
            this.btnMaestra.Size = new System.Drawing.Size(169, 69);
            this.btnMaestra.TabIndex = 20;
            this.btnMaestra.Text = "Usuarios";
            this.btnMaestra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaestra.UseVisualStyleBackColor = false;
            this.btnMaestra.Click += new System.EventHandler(this.btnMaestra_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsulta.Image = global::Proyecto.Properties.Resources.fileboard___1801_;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(12, 42);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(169, 69);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "   Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel6.Location = new System.Drawing.Point(-19, 538);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(32, 69);
            this.panel6.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Proyecto.Properties.Resources.key___677_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 69);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel3.Location = new System.Drawing.Point(-15, 260);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 69);
            this.panel3.TabIndex = 3;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistorial.Image = global::Proyecto.Properties.Resources.edit___1479_;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(16, 260);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(169, 69);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(-15, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 69);
            this.panel2.TabIndex = 1;
            // 
            // btnKardex
            // 
            this.btnKardex.BackColor = System.Drawing.Color.Transparent;
            this.btnKardex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKardex.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnKardex.FlatAppearance.BorderSize = 0;
            this.btnKardex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnKardex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKardex.Image = global::Proyecto.Properties.Resources.fileboard___1801_;
            this.btnKardex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKardex.Location = new System.Drawing.Point(16, 184);
            this.btnKardex.Margin = new System.Windows.Forms.Padding(4);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Size = new System.Drawing.Size(156, 69);
            this.btnKardex.TabIndex = 2;
            this.btnKardex.Text = "Kardex";
            this.btnKardex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKardex.UseVisualStyleBackColor = false;
            this.btnKardex.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(-15, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 69);
            this.panel1.TabIndex = 0;
            // 
            // PanelP
            // 
            this.PanelP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(119)))));
            this.PanelP.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelP.Location = new System.Drawing.Point(190, 37);
            this.PanelP.Margin = new System.Windows.Forms.Padding(4);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(1153, 668);
            this.PanelP.TabIndex = 3;
            this.PanelP.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelP_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Froma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1343, 705);
            this.Controls.Add(this.PanelP);
            this.Controls.Add(this.PanelMV);
            this.Controls.Add(this.PanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Froma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicMIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.PanelMV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Panel PanelMV;
        private System.Windows.Forms.Panel PanelP;
        private System.Windows.Forms.PictureBox PicMIn;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKardex;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnMaestra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnIniciar;
    }
}

