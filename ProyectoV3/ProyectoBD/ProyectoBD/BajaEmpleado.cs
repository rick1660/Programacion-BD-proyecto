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
    public partial class BajaEmpleado : Form
    {
        public BajaEmpleado()
        {
            InitializeComponent();
        }

        Consulta2 objetoEmpleado = new Consulta2();
        private string IdEmpleado = null;
        private bool Editar = false;

        private void MostrarEmpleado()
        {

            Consulta2 objeto = new Consulta2();
            DataGEmpleado.DataSource = objeto.MostrarEmpleado();
        }

        private void BajaEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGEmpleado.SelectedRows.Count > 0)
            {
                IdEmpleado = DataGEmpleado.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                objetoEmpleado.EliminarEmpleado(IdEmpleado);
                MessageBox.Show("Eliminado correctamente");
                MostrarEmpleado();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
