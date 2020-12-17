using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class BajaAutomovil : Form
    {
        public BajaAutomovil()
        {
            InitializeComponent();
        }


        Consulta2 objetoAutomovil = new Consulta2();
        private string IdVehiculo = null;
        private bool Editar = false;

        private void MostrarAutomovil()
        {

            Consulta2 objeto = new Consulta2();
            DataGAutomovil.DataSource = objeto.MostrarAutomovil();
        }



        private void BajaAutomovil_Load(object sender, EventArgs e)
        {
            MostrarAutomovil();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGAutomovil.SelectedRows.Count > 0)
            {
                IdVehiculo = DataGAutomovil.CurrentRow.Cells["IdVehiculo"].Value.ToString();
                objetoAutomovil.EliminarVehiculo(IdVehiculo);
                MessageBox.Show("Eliminado correctamente");
                MostrarAutomovil();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
