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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void lblAutos_Click(object sender, EventArgs e)
        {

        }

        private void dgbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            Consultas2 objetoMostrar = new Consultas2();
            dgbClientes.DataSource = objetoMostrar.MostrarCliente();
        }
    }
}
