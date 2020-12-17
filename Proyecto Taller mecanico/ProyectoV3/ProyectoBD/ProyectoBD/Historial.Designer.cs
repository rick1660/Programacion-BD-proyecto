namespace ProyectoBD
{
    partial class Historial
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
            this.DataGHistorial = new System.Windows.Forms.DataGridView();
            this.lblHistorial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGHistorial
            // 
            this.DataGHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGHistorial.Location = new System.Drawing.Point(12, 102);
            this.DataGHistorial.Name = "DataGHistorial";
            this.DataGHistorial.RowHeadersWidth = 51;
            this.DataGHistorial.RowTemplate.Height = 24;
            this.DataGHistorial.Size = new System.Drawing.Size(776, 468);
            this.DataGHistorial.TabIndex = 0;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(199, 37);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(393, 38);
            this.lblHistorial.TabIndex = 28;
            this.lblHistorial.Text = "HISTORIAL DE ACCESO";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.DataGHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGHistorial;
        private System.Windows.Forms.Label lblHistorial;
    }
}