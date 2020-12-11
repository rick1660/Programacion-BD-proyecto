namespace Concesionaria
{
    partial class Admin
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
            this.Administrador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = true;
            this.Administrador.Location = new System.Drawing.Point(373, 57);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(70, 13);
            this.Administrador.TabIndex = 0;
            this.Administrador.Text = "Administrador";
            this.Administrador.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.Administrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Administrador;
    }
}