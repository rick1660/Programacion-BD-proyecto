namespace ProyectoBD
{
    partial class frmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.automovilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refaccionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.altasToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 59);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(34, 55);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.automovilToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.refaccionToolStripMenuItem,
            this.servicioToolStripMenuItem});
            this.altasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
            this.altasToolStripMenuItem.Text = "Altas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // automovilToolStripMenuItem
            // 
            this.automovilToolStripMenuItem.Name = "automovilToolStripMenuItem";
            this.automovilToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.automovilToolStripMenuItem.Text = "Automovil";
            this.automovilToolStripMenuItem.Click += new System.EventHandler(this.automovilToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            this.diagnosticoToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoToolStripMenuItem_Click);
            // 
            // refaccionToolStripMenuItem
            // 
            this.refaccionToolStripMenuItem.Name = "refaccionToolStripMenuItem";
            this.refaccionToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.refaccionToolStripMenuItem.Text = "Refaccion";
            this.refaccionToolStripMenuItem.Click += new System.EventHandler(this.refaccionToolStripMenuItem_Click);
            // 
            // servicioToolStripMenuItem
            // 
            this.servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            this.servicioToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.servicioToolStripMenuItem.Text = "Servicio";
            this.servicioToolStripMenuItem.Click += new System.EventHandler(this.servicioToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.automovilToolStripMenuItem1,
            this.empleadoToolStripMenuItem1,
            this.refaccionToolStripMenuItem1});
            this.bajasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(60, 55);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // automovilToolStripMenuItem1
            // 
            this.automovilToolStripMenuItem1.Name = "automovilToolStripMenuItem1";
            this.automovilToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.automovilToolStripMenuItem1.Text = "Automovil";
            this.automovilToolStripMenuItem1.Click += new System.EventHandler(this.automovilToolStripMenuItem1_Click);
            // 
            // empleadoToolStripMenuItem1
            // 
            this.empleadoToolStripMenuItem1.Name = "empleadoToolStripMenuItem1";
            this.empleadoToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.empleadoToolStripMenuItem1.Text = "Empleado";
            this.empleadoToolStripMenuItem1.Click += new System.EventHandler(this.empleadoToolStripMenuItem1_Click);
            // 
            // refaccionToolStripMenuItem1
            // 
            this.refaccionToolStripMenuItem1.Name = "refaccionToolStripMenuItem1";
            this.refaccionToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.refaccionToolStripMenuItem1.Text = "Refaccion";
            this.refaccionToolStripMenuItem1.Click += new System.EventHandler(this.refaccionToolStripMenuItem1_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem2,
            this.automovilToolStripMenuItem2,
            this.empleadoToolStripMenuItem2,
            this.refaccionToolStripMenuItem2});
            this.actualizacionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(116, 55);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // automovilToolStripMenuItem2
            // 
            this.automovilToolStripMenuItem2.Name = "automovilToolStripMenuItem2";
            this.automovilToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.automovilToolStripMenuItem2.Text = "Automovil";
            this.automovilToolStripMenuItem2.Click += new System.EventHandler(this.automovilToolStripMenuItem2_Click);
            // 
            // empleadoToolStripMenuItem2
            // 
            this.empleadoToolStripMenuItem2.Name = "empleadoToolStripMenuItem2";
            this.empleadoToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.empleadoToolStripMenuItem2.Text = "Empleado";
            this.empleadoToolStripMenuItem2.Click += new System.EventHandler(this.empleadoToolStripMenuItem2_Click);
            // 
            // refaccionToolStripMenuItem2
            // 
            this.refaccionToolStripMenuItem2.Name = "refaccionToolStripMenuItem2";
            this.refaccionToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.refaccionToolStripMenuItem2.Text = "Refaccion";
            this.refaccionToolStripMenuItem2.Click += new System.EventHandler(this.refaccionToolStripMenuItem2_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(82, 55);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 59);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(800, 591);
            this.PanelContenedor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(733, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automovilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refaccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem automovilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refaccionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem automovilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refaccionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button button1;
    }
}

