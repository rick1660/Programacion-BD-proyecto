namespace Concesionaria
{
    partial class Autos
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
            this.dgbAutos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(368, 18);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(85, 29);
            this.lblAutos.TabIndex = 11;
            this.lblAutos.Text = " Autos";
            this.lblAutos.Click += new System.EventHandler(this.lblAutos_Click);
            // 
            // dgbAutos
            // 
            this.dgbAutos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAutos.Location = new System.Drawing.Point(0, 50);
            this.dgbAutos.Name = "dgbAutos";
            this.dgbAutos.Size = new System.Drawing.Size(821, 255);
            this.dgbAutos.TabIndex = 15;
            this.dgbAutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbClientes_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Teal;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(501, 377);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 42);
            this.btnModificar.TabIndex = 60;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(345, 377);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 42);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(186, 377);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 42);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(821, 600);
            this.panel.TabIndex = 61;
            this.panel.Visible = false;
            // 
            // Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgbAutos);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autos";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.Autos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.DataGridView dgbAutos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel;
    }
}