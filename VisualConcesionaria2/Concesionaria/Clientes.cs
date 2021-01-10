using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionaria
{
    public partial class Clientes : Form
    {
       


        Consultas2 objetoCliente = new Consultas2();
        private string IdCliente = null;

        public Clientes()
        {
            InitializeComponent();
        }
        Login no = new Login();
        Form1 Principal = new Form1("hola");

       

        private void MostrarCliente()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbClientes.DataSource = objetoMostrar.MostrarCliente();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        ModificarCliente registro = new ModificarCliente();

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new ModificarCliente());
            this.panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgbClientes.SelectedRows.Count > 0)
            {
                IdCliente = dgbClientes.CurrentRow.Cells["IdClientes"].Value.ToString();
                objetoCliente.EliminarCliente(IdCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarCliente();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirFormEnPanel1(object Formhijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new AgregarCliente());
            this.panel.Visible = true;
        }

        public void CerrarPanel() 
        {
            this.panel.Visible = false;
        }
    }
}
