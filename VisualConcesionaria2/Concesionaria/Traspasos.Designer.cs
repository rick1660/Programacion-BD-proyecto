namespace Concesionaria
{
    partial class Traspasos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxOrigen = new System.Windows.Forms.ComboBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxAutos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutos
            // 
            this.lblAutos.AutoSize = true;
            this.lblAutos.BackColor = System.Drawing.Color.Transparent;
            this.lblAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutos.ForeColor = System.Drawing.Color.Teal;
            this.lblAutos.Location = new System.Drawing.Point(334, 21);
            this.lblAutos.Name = "lblAutos";
            this.lblAutos.Size = new System.Drawing.Size(136, 29);
            this.lblAutos.TabIndex = 13;
            this.lblAutos.Text = "Traspasos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 138);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(104, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sucursal origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sucursal Destino:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(178, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo Traspaso:";
            // 
            // cbxOrigen
            // 
            this.cbxOrigen.FormattingEnabled = true;
            this.cbxOrigen.Location = new System.Drawing.Point(178, 111);
            this.cbxOrigen.Name = "cbxOrigen";
            this.cbxOrigen.Size = new System.Drawing.Size(137, 21);
            this.cbxOrigen.TabIndex = 23;
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(178, 148);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(137, 21);
            this.cbxDestino.TabIndex = 24;
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "yyyy/mm/dd";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(178, 71);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(137, 20);
            this.dateFecha.TabIndex = 27;
            // 
            // cbxAutos
            // 
            this.cbxAutos.FormattingEnabled = true;
            this.cbxAutos.Location = new System.Drawing.Point(610, 74);
            this.cbxAutos.Name = "cbxAutos";
            this.cbxAutos.Size = new System.Drawing.Size(137, 21);
            this.cbxAutos.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(543, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Autos:";
            // 
            // Traspasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 600);
            this.Controls.Add(this.cbxAutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxOrigen);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Traspasos";
            this.Text = "Traspasos";
            this.Load += new System.EventHandler(this.Traspasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxOrigen;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox cbxAutos;
        private System.Windows.Forms.Label label5;
    }
}