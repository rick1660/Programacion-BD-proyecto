﻿namespace ProyectoBD
{
    partial class BajaAutomovil
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
            this.lblBajaAutomovil = new System.Windows.Forms.Label();
            this.DataGAutomovil = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGAutomovil)).BeginInit();
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
            this.btnEliminar.TabIndex = 12;
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
            this.lblTexto.TabIndex = 11;
            this.lblTexto.Text = "SELECCIONA AUTOMOVIL A DAR DE BAJA:";
            // 
            // lblBajaAutomovil
            // 
            this.lblBajaAutomovil.AutoSize = true;
            this.lblBajaAutomovil.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaAutomovil.ForeColor = System.Drawing.Color.Black;
            this.lblBajaAutomovil.Location = new System.Drawing.Point(259, 9);
            this.lblBajaAutomovil.Name = "lblBajaAutomovil";
            this.lblBajaAutomovil.Size = new System.Drawing.Size(307, 38);
            this.lblBajaAutomovil.TabIndex = 10;
            this.lblBajaAutomovil.Text = "BAJA AUTOMOVIL";
            // 
            // DataGAutomovil
            // 
            this.DataGAutomovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGAutomovil.Location = new System.Drawing.Point(21, 114);
            this.DataGAutomovil.Name = "DataGAutomovil";
            this.DataGAutomovil.RowHeadersWidth = 51;
            this.DataGAutomovil.RowTemplate.Height = 24;
            this.DataGAutomovil.Size = new System.Drawing.Size(767, 363);
            this.DataGAutomovil.TabIndex = 9;
            // 
            // BajaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblBajaAutomovil);
            this.Controls.Add(this.DataGAutomovil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajaAutomovil";
            this.Text = "BajaAutomovil";
            this.Load += new System.EventHandler(this.BajaAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGAutomovil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblBajaAutomovil;
        private System.Windows.Forms.DataGridView DataGAutomovil;
    }
}