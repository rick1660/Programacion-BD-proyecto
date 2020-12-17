using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Concesionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 179)
            {
                MenuVertical.Width = 69;
            }
            else
            {
                MenuVertical.Width = 179;
            }
        }

        private void ptxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptxRestaurar.Visible = true;
            ptxExtender.Visible = false;
        }

        private void ptxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptxRestaurar.Visible = false;
            ptxExtender.Visible = true;
        }

        private void ptxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Autos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Empelados());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Admin());
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Compra());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Venta());
        }

        private void btnAccesorios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Accesorios());
        }

        private void btnTraspasos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Traspasos());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Bitacoras());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Reportes());
        }

        private void BarraHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
