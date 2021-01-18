
namespace Concesionaria
{
    partial class AutosTraspaso
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
            this.dgbAutos = new System.Windows.Forms.DataGridView();
            this.lblAutos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleTraspaso = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTraspaso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbAutos
            // 
            this.dgbAutos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAutos.Location = new System.Drawing.Point(92, 70);
            this.dgbAutos.Name = "dgbAutos";
            this.dgbAutos.Size = new System.Drawing.Size(821, 202);
            this.dgbAutos.TabIndex = 16;
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(319, 27);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(414, 29);
            this.lblAutos.TabIndex = 17;
            this.lblAutos.Text = "Seleccion de autos Para Traspaso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(365, 299);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(293, 42);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalleTraspaso
            // 
            this.dgvDetalleTraspaso.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalleTraspaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTraspaso.Location = new System.Drawing.Point(92, 366);
            this.dgvDetalleTraspaso.Name = "dgvDetalleTraspaso";
            this.dgvDetalleTraspaso.Size = new System.Drawing.Size(821, 202);
            this.dgvDetalleTraspaso.TabIndex = 20;
            this.dgvDetalleTraspaso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleTraspaso_CellContentClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Teal;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(392, 586);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(236, 42);
            this.btnFinalizar.TabIndex = 21;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // AutosTraspaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 716);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvDetalleTraspaso);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblAutos);
            this.Controls.Add(this.dgbAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutosTraspaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutosTraspaso";
            this.Load += new System.EventHandler(this.AutosTraspaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTraspaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbAutos;
        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleTraspaso;
        private System.Windows.Forms.Button btnFinalizar;
    }
}