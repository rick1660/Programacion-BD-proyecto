using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD;

namespace ProyectoBD
{
    public partial class AltaDiagnostico : Form
    {
        public AltaDiagnostico()
        {
            InitializeComponent();
        }


        Consulta2 objetoDiagnostico = new Consulta2();
        private string idDiagnostico = null;
        private bool Editar = false;

        private void AltaDiagnostico_Load(object sender, EventArgs e)
        {
            MostrarDiagnostico();
        }
        private void MostrarDiagnostico()
        {

            Consulta2 objetoMostrar = new Consulta2();
            DataGAlta.DataSource = objetoMostrar.MostrarDiagnostico();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoDiagnostico.InsertarDiagnostico(txtIdDiagnostico.Text, txtDescripcion.Text, txtCausa.Text, txtIdVehiculo.Text);
                    MessageBox.Show("Datos Insertados Correctamente");
                    MostrarDiagnostico();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }
    }
}
