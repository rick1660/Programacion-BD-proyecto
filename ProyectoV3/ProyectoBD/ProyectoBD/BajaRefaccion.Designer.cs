namespace ProyectoBD
{
    partial class BajaRefaccion
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblRefaccion = new System.Windows.Forms.Label();
            this.DataGRefaccion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGRefaccion)).BeginInit();
            this.SuspendLayout();
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
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(243, 73);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(300, 17);
            this.lblTexto.TabIndex = 19;
            this.lblTexto.Text = "SELECCIONA AUTOMOVIL A DAR DE BAJA:";
            // 
            // lblRefaccion
            // 
            this.lblRefaccion.AutoSize = true;
            this.lblRefaccion.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefaccion.ForeColor = System.Drawing.Color.Black;
            this.lblRefaccion.Location = new System.Drawing.Point(259, 9);
            this.lblRefaccion.Name = "lblRefaccion";
            this.lblRefaccion.Size = new System.Drawing.Size(304, 38);
            this.lblRefaccion.TabIndex = 18;
            this.lblRefaccion.Text = "BAJA REFACCION\r\n";
            // 
            // DataGRefaccion
            // 
            this.DataGRefaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGRefaccion.Location = new System.Drawing.Point(21, 114);
            this.DataGRefaccion.Name = "DataGRefaccion";
            this.DataGRefaccion.RowHeadersWidth = 51;
            this.DataGRefaccion.RowTemplate.Height = 24;
            this.DataGRefaccion.Size = new System.Drawing.Size(767, 363);
            this.DataGRefaccion.TabIndex = 17;
            // 
            // BajaRefaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblRefaccion);
            this.Controls.Add(this.DataGRefaccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaRefaccion";
            this.Text = "BajaRefaccion";
            this.Load += new System.EventHandler(this.BajaRefaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGRefaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblRefaccion;
        private System.Windows.Forms.DataGridView DataGRefaccion;
    }
}