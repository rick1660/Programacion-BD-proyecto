namespace ProyectoBD
{
    partial class BajaCliente
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
            this.DataGBajaCliente = new System.Windows.Forms.DataGridView();
            this.lblBajaCliente = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGBajaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGBajaCliente
            // 
            this.DataGBajaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGBajaCliente.Location = new System.Drawing.Point(21, 114);
            this.DataGBajaCliente.Name = "DataGBajaCliente";
            this.DataGBajaCliente.RowHeadersWidth = 51;
            this.DataGBajaCliente.RowTemplate.Height = 24;
            this.DataGBajaCliente.Size = new System.Drawing.Size(767, 363);
            this.DataGBajaCliente.TabIndex = 0;
            this.DataGBajaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGBajaCliente_CellContentClick);
            // 
            // lblBajaCliente
            // 
            this.lblBajaCliente.AutoSize = true;
            this.lblBajaCliente.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaCliente.ForeColor = System.Drawing.Color.Black;
            this.lblBajaCliente.Location = new System.Drawing.Point(259, 9);
            this.lblBajaCliente.Name = "lblBajaCliente";
            this.lblBajaCliente.Size = new System.Drawing.Size(253, 38);
            this.lblBajaCliente.TabIndex = 1;
            this.lblBajaCliente.Text = "BAJA CLIENTE";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(243, 73);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(280, 17);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "SELECCIONA CLIENTE A DAR DE BAJA:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(270, 496);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(253, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblBajaCliente);
            this.Controls.Add(this.DataGBajaCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaCliente";
            this.Text = "BajaCliente";
            this.Load += new System.EventHandler(this.BajaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGBajaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGBajaCliente;
        private System.Windows.Forms.Label lblBajaCliente;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnEliminar;
    }
}