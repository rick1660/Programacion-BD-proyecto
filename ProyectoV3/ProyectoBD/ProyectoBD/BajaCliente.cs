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

using ProyectoBD;


namespace ProyectoBD
{
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
        }

        Consulta2 objetoCliente = new Consulta2();
        private string IdCliente = null;
        private bool Editar = false;

        private void MostrarCliente()
        {

            Consulta2 objeto = new Consulta2();
            DataGBajaCliente.DataSource = objeto.MostrarCliente();
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGBajaCliente.SelectedRows.Count > 0)
            {
                IdCliente = DataGBajaCliente.CurrentRow.Cells["IdCliente"].Value.ToString();
                objetoCliente.EliminarCliente(IdCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarCliente();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void DataGBajaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BajaCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }
    }
}
