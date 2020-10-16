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
    public partial class AltaRefaccion : Form
    {
        public AltaRefaccion()
        {
            InitializeComponent();
        }


        Consulta2 objetoRefaccion = new Consulta2();
        private string IdRefaccion = null;
        private bool Editar = false;

        private void MostrarRefaccion()
        {

            Consulta2 objeto = new Consulta2();
            DataGAlta.DataSource = objeto.MostrarRefaccion();
        }

        private void AltaRefaccion_Load(object sender, EventArgs e)
        {
            MostrarRefaccion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoRefaccion.InsertarRefaccion(txtIdRefaccion.Text, txtNombre.Text, txtCosto.Text, txtFechaE.Text, txtFechaS.Text, txtDepart.Text);
                    MessageBox.Show("Datos Insertados Correctamente");
                    MostrarRefaccion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }
    }
}
