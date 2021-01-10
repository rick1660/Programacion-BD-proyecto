namespace Concesionaria
{
    partial class EliminarCliente
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
            this.dgbClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(298, 23);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(199, 29);
            this.lblAutos.TabIndex = 15;
            this.lblAutos.Text = "Eliminar Cliente";
            this.lblAutos.Click += new System.EventHandler(this.lblAutos_Click);
            // 
            // dgbClientes
            // 
            this.dgbClientes.AllowUserToAddRows = false;
            this.dgbClientes.AllowUserToDeleteRows = false;
            this.dgbClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbClientes.Location = new System.Drawing.Point(-3, 55);
            this.dgbClientes.Name = "dgbClientes";
            this.dgbClientes.ReadOnly = true;
            this.dgbClientes.Size = new System.Drawing.Size(793, 182);
            this.dgbClientes.TabIndex = 16;
            this.dgbClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbClientes_CellContentClick);
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 522);
            this.Controls.Add(this.dgbClientes);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.DataGridView dgbClientes;
    }
}