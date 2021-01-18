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
    public partial class AutosTraspaso : Form
    {
        int UsarTraspaso;
        public AutosTraspaso(int IdTraspaso)
        {
            InitializeComponent();
            UsarTraspaso = IdTraspaso;
        }
        Traspasos Tras = new Traspasos();
        private void AutosTraspaso_Load(object sender, EventArgs e)
        {
            MostrarAutos();
        }


        private void MostrarAutos()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAutos.DataSource = objetoMostrar.MostrarAutos();
        }

        private void MostrarDetalleTraspasos()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgvDetalleTraspaso.DataSource = objetoMostrar.MostrarDetalleTraspaso(UsarTraspaso);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgbAutos.SelectedRows.Count > 0)
            {

              

                Consultas2 Metodo = new Consultas2();

                Metodo.InsertarDetalleTraspaso(UsarTraspaso, Convert.ToInt32(dgbAutos.CurrentRow.Cells["IdAutomovil"].Value.ToString()));
              
                MostrarAutos();
                MostrarDetalleTraspasos();
             


            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void dgvDetalleTraspaso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
