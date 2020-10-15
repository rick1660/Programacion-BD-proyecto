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
    public partial class AltaServicio : Form
    {
        public AltaServicio()
        {
            InitializeComponent();
        }


        Consulta2 objetoServicio = new Consulta2();
        private string IdServicio = null;
        private bool Editar = false;

        private void MostrarServicios()
        {

            Consulta2 objeto = new Consulta2();
            DataGAlta.DataSource = objeto.MostrarServicios();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoServicio.InsertarServicio(txtIdServicio.Text, txtCosto.Text, txtFecha.Text, txtNombre.Text, txtPromo.Text, txtInicioG.Text, txtFinalG.Text, txtIdDiag.Text, txtIdDepart.Text, txtCount.Text);
                    MessageBox.Show("Datos Insertados Correctamente");
                    MostrarServicios();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }

        private void AltaServicio_Load(object sender, EventArgs e)
        {
            MostrarServicios();
        }
    }
}
