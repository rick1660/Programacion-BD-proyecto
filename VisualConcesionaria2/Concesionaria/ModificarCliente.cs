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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

      

        private void MostrarCliente()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dtgClientes.DataSource = objetoMostrar.MostrarCliente();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
           
            MostrarCliente();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {

                txtNombre.ForeColor = Color.Black;
                txtApellidos.ForeColor = Color.Black;
                txtPassword.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.Black;
                txtTel.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtEdad.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.Black;
                cmxGenero.ForeColor = Color.Black;
                txtFechaNa.ForeColor = Color.Black;
                txtRFC.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.Black;
                txtReferencia1.ForeColor = Color.Black;
                txtNumR1.ForeColor = Color.Black;
                txtReferencia2.ForeColor = Color.Black;
                txtNumR2.ForeColor = Color.Black;
                txtReferencia3.ForeColor = Color.Black;
                txtNumR3.ForeColor = Color.Black;



               

                txtNombre.Text = dtgClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = dtgClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtPassword.Text = dtgClientes.CurrentRow.Cells["PasswordCliente"].Value.ToString();
                txtDireccion.Text = dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTel.Text = dtgClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dtgClientes.CurrentRow.Cells["Correo"].Value.ToString();
                txtEdad.Text = dtgClientes.CurrentRow.Cells["Edad"].Value.ToString();
                txtDireccion.Text = dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                cmxGenero.Text = dtgClientes.CurrentRow.Cells["Sexo"].Value.ToString();
                txtFechaNa.Text = dtgClientes.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                txtRFC.Text = dtgClientes.CurrentRow.Cells["RFC"].Value.ToString();
                txtDireccion.Text = dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtReferencia1.Text = dtgClientes.CurrentRow.Cells["ReferenciaUno"].Value.ToString();
                txtNumR1.Text = dtgClientes.CurrentRow.Cells["NumRefUno"].Value.ToString();
                txtReferencia2.Text = dtgClientes.CurrentRow.Cells["ReferenciaDos"].Value.ToString();
                txtNumR2.Text = dtgClientes.CurrentRow.Cells["NumRedDos"].Value.ToString();
                txtReferencia3.Text = dtgClientes.CurrentRow.Cells["ReferenciaTres"].Value.ToString();
                txtNumR3.Text = dtgClientes.CurrentRow.Cells["NumRefTres"].Value.ToString();

               

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {

            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.Black;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
                txtApellidos.ForeColor = Color.Gray;
            }
        }

        private void textTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "Telefono")
            {
                txtTel.Text = "";
                txtTel.ForeColor = Color.Black;
            }
        }

        private void textTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "Telefono";
                txtTel.ForeColor = Color.Gray;
            }
        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void textEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "Edad")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;
            }
        }

        private void textEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "Edad";
                txtEdad.ForeColor = Color.Gray;
            }
        }





        private void txtFechaNa_Enter(object sender, EventArgs e)
        {
            if (txtFechaNa.Text == "Fecha  de nacimiento  (AAA-MM-DD)")
            {
                txtFechaNa.Text = "";
                txtFechaNa.ForeColor = Color.Black;
            }
        }

        private void txtFechaNa_Leave(object sender, EventArgs e)
        {
            if (txtFechaNa.Text == "")
            {
                txtFechaNa.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
                txtFechaNa.ForeColor = Color.Gray;
            }
        }

        private void textRFC_Enter(object sender, EventArgs e)
        {
            if (txtRFC.Text == "RFC")
            {
                txtRFC.Text = "";
                txtRFC.ForeColor = Color.Black;
            }
        }

        private void textRFC_Leave(object sender, EventArgs e)
        {
            if (txtRFC.Text == "")
            {
                txtRFC.Text = "RFC";
                txtRFC.ForeColor = Color.Gray;
            }
        }

        private void textReferencia1_Enter(object sender, EventArgs e)
        {
            if (txtReferencia1.Text == "Nombre")
            {
                txtReferencia1.Text = "";
                txtReferencia1.ForeColor = Color.Black;
            }
        }

        private void textReferencia1_Leave(object sender, EventArgs e)
        {
            if (txtReferencia1.Text == "")
            {
                txtReferencia1.Text = "Nombre";
                txtReferencia1.ForeColor = Color.Gray;
            }
        }

        private void textNumR1_Enter(object sender, EventArgs e)
        {
            if (txtNumR1.Text == "Telefono")
            {
                txtNumR1.Text = "";
                txtNumR1.ForeColor = Color.Black;
            }
        }

        private void textNumR1_Leave(object sender, EventArgs e)
        {
            if (txtNumR1.Text == "")
            {
                txtNumR1.Text = "Telefono";
                txtNumR1.ForeColor = Color.Gray;
            }
        }

        private void textReferencia2_Enter(object sender, EventArgs e)
        {
            if (txtReferencia2.Text == "Nombre")
            {
                txtReferencia2.Text = "";
                txtReferencia2.ForeColor = Color.Black;
            }
        }

        private void textReferencia2_Leave(object sender, EventArgs e)
        {
            if (txtReferencia2.Text == "")
            {
                txtReferencia2.Text = "Nombre";
                txtReferencia2.ForeColor = Color.Gray;
            }
        }

        private void textNumR2_Enter(object sender, EventArgs e)
        {
            if (txtNumR2.Text == "Telefono")
            {
                txtNumR2.Text = "";
                txtNumR2.ForeColor = Color.Black;
            }
        }

        private void textNumR2_Leave(object sender, EventArgs e)
        {
            if (txtNumR2.Text == "")
            {
                txtNumR2.Text = "Telefono";
                txtNumR2.ForeColor = Color.Gray;
            }
        }

        private void textNumR3_Enter(object sender, EventArgs e)
        {
            if (txtNumR3.Text == "Telefono")
            {
                txtNumR3.Text = "";
                txtNumR3.ForeColor = Color.Black;
            }
        }

        private void textNumR3_Leave(object sender, EventArgs e)
        {
            if (txtNumR3.Text == "")
            {
                txtNumR3.Text = "Telefono";
                txtNumR3.ForeColor = Color.Gray;
            }
        }

        private void txtReferencia3_Enter(object sender, EventArgs e)
        {
            if (txtReferencia3.Text == "Nombre")
            {
                txtReferencia3.Text = "";
                txtReferencia3.ForeColor = Color.Black;
            }
        }

        private void txtReferencia3_Leave(object sender, EventArgs e)
        {
            if (txtReferencia3.Text == "")
            {
                txtReferencia3.Text = "Nombre";
                txtReferencia3.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Direccion";
                txtDireccion.ForeColor = Color.Gray;
            }
        }

        private void txtNumR2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Consultas2 objetoCliente = new Consultas2();
            try 
            { 


              
                objetoCliente.EditarCliente(txtNombre.Text, txtApellidos.Text, txtPassword.Text, txtTel.Text, txtCorreo.Text, txtEdad.Text, txtDireccion.Text, cmxGenero.Text, txtFechaNa.Text, txtRFC.Text, txtReferencia1.Text, txtNumR1.Text, txtReferencia2.Text, txtNumR2.Text, txtReferencia3.Text, txtNumR3.Text);
                MessageBox.Show("* Se edito correctamente *");
                MostrarCliente();


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }
    }


}



