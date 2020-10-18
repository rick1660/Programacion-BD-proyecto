using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace ProyectoBD
{
    public partial class frmHome : Form
    {
    
        public frmHome()
        {
            InitializeComponent();
        }

        // Creacion de Views de Forms ALTAS
        private void AbrirAltaC(object altacliente)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = altacliente as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirAltaAuto(object altaauto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = altaauto as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirAltaEmp(object altaemp)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = altaemp as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirAltaDiagnostico(object altadiag)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = altadiag as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirAltaRefaccion(object altarefac)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = altarefac as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirAltaServicio(object altaserv)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = altaserv as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        // Creacion de Views de Forms BAJAS

        private void AbrirBajaC(object bajacliente)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = bajacliente as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirBajaAuto(object bajaauto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = bajaauto as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirBajaEmp(object bajaemp)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = bajaemp as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }


        private void AbrirBajaRefac(object bajarefac)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = bajarefac as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }



        // Creacion de Views de Forms ACTUALIZAR
        private void AbrirActualizarC(object actualizarcliente)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = actualizarcliente as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirActualizarAuto(object actauto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = actauto as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void AbrirActualizarEmp(object actemp)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = actemp as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }


        private void AbrirActualizacionRefac(object actrefac)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = actrefac as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }


        private void AbrirHistorial(object historial)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = historial as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }




        private void AbrirHome(object ahome)
        {
           
            Form fh = ahome as Form;
            fh.Show();
        }




        // Llamar la funcion para abrir form ALTAS
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAltaC(new AltaCliente ());
 
        }

        private void automovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAltaAuto(new AltaAutomovil());

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAltaEmp(new AltaEmpleado());
      
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAltaDiagnostico(new AltaDiagnostico());

        }

        private void refaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAltaRefaccion(new AltaRefaccion());

        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirAltaServicio(new AltaServicio());
        
        }


        // Llamar la funcion para abrir form BAJAS
        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirBajaC(new BajaCliente());
        }

        private void automovilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirBajaAuto(new BajaAutomovil());

        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirBajaEmp(new BajaEmpleado());

        }

        private void refaccionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirBajaRefac(new BajaRefaccion());
   
        }
        // Llamar la funcion para abrir form ACTUALIZAR
        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirActualizarC(new ActualizarCliente());

        }

        private void automovilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirActualizarAuto(new ActualizarAutomovil());
           
        }

        private void empleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirActualizarEmp(new ActualizacionEmpleado());
       
        }

        private void refaccionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirActualizacionRefac(new ActualizacionRefaccion());
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirHome(new frmHome());

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirHistorial(new Historial());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
