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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Principal.AbrirFormEnPanel(new AgregarCliente());
            MessageBox.Show("Correo y/o contraseña incorrecta");

        }
    }
}
