namespace Concesionaria
{
    partial class Accesorios
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgbAccesorios = new System.Windows.Forms.DataGridView();
            this.lblAutos = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAccesorios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(500, 380);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 42);
            this.btnModificar.TabIndex = 65;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(344, 380);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 42);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(185, 380);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 42);
            this.btnAgregar.TabIndex = 63;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgbAccesorios
            // 
            this.dgbAccesorios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAccesorios.Location = new System.Drawing.Point(-1, 53);
            this.dgbAccesorios.Name = "dgbAccesorios";
            this.dgbAccesorios.Size = new System.Drawing.Size(821, 255);
            this.dgbAccesorios.TabIndex = 62;
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(339, 11);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(142, 29);
            this.lblAutos.TabIndex = 61;
            this.lblAutos.Text = "Accesorios";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(-1, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(821, 603);
            this.panel.TabIndex = 66;
            this.panel.Visible = false;
            // 
            // Accesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgbAccesorios);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accesorios";
            this.Text = "Accesorios";
            this.Load += new System.EventHandler(this.Accesorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbAccesorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgbAccesorios;
        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.Panel panel;
    }
}