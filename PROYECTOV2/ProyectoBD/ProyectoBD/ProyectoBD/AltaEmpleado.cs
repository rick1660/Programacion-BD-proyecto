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
    public partial class AltaEmpleado : Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }


        Consulta2 objetoEmpleado = new Consulta2();
        private string IdEmpleado = null;
        private bool Editar = false;

        private void MostrarEmpleado()
        {

            Consulta2 objeto = new Consulta2();
            DataGAlta.DataSource = objeto.MostrarEmpleado();
        }


        private void AltaEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoEmpleado.InsertarEmpleado(txtEmpleado.Text, txtNombre.Text, txtTelef.Text, txtIdDepar.Text, txtIdVehiculo.Text);
                    MessageBox.Show("Datos Insertados Correctamente");
                    MostrarEmpleado();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }
    }
}
