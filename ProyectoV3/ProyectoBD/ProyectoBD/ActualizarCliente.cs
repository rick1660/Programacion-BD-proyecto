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
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
        {
            InitializeComponent();
        }



        Consulta2 objetoCliente = new Consulta2();
        private string IdCliente = null;


        private void MostrarCliente()
        {

            Consulta2 objeto = new Consulta2();
            DataGActualizar.DataSource = objeto.MostrarCliente();
        }





        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                objetoCliente.EditarCliente(txtIdCliente.Text, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                MessageBox.Show("* Se edito correctamente *");
                MostrarCliente();


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DataGActualizar.SelectedRows.Count > 0)
            {
                txtIdCliente.Text = DataGActualizar.CurrentRow.Cells["IdCliente"].Value.ToString();
                txtNombre.Text = DataGActualizar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = DataGActualizar.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtDireccion.Text = DataGActualizar.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = DataGActualizar.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = DataGActualizar.CurrentRow.Cells["Correo"].Value.ToString();
             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
