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
    public partial class AltaCliente : Form
    {

        Consulta2 objetoCliente = new Consulta2();
        private string idCliente = null;
        private bool Editar = false;


        public AltaCliente()
        {
            InitializeComponent();
        }

        private void MostrarCliente()
        {

            Consulta2 objetoMostrar = new Consulta2();
            DataGAlta.DataSource = objetoMostrar.MostrarCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCliente.InsertarCliente(txtIdCliente.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                    MessageBox.Show("Datos Insertados Correctamente");
                    MostrarCliente();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }
    }
}
