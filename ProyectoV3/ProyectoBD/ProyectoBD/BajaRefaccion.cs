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
    public partial class BajaRefaccion : Form
    {
        public BajaRefaccion()
        {
            InitializeComponent();
        }

        Consulta2 objetoRefaccion = new Consulta2();
        private string IdRefaccion = null;
        private bool Editar = false;

        private void MostrarRefaccion()
        {

            Consulta2 objeto = new Consulta2();
            DataGRefaccion.DataSource = objeto.MostrarRefaccion();
        }


        private void BajaRefaccion_Load(object sender, EventArgs e)
        {
            MostrarRefaccion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGRefaccion.SelectedRows.Count > 0)
            {
                IdRefaccion = DataGRefaccion.CurrentRow.Cells["IdRefaccion"].Value.ToString();
                objetoRefaccion.EliminarRefaccion(IdRefaccion);
                MessageBox.Show("Eliminado correctamente");
                MostrarRefaccion();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
