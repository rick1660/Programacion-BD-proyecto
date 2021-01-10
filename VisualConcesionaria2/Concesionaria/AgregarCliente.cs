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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        Consultas2 objetoCliente = new Consultas2();

        private void lblAutos_Click(object sender, EventArgs e)
        {




        }
      

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            bool isOK = true;
            if (txtNombre.Text == "Nombre" || txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese su Nombre");
                isOK = false;
            }


            if (txtApellidos.Text == "Apellidos" || txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese sus Apellidos");
                isOK = false;
            }


            if (txtPassword.Text == "Contraseña" || txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Establesca una contraseña");
                isOK = false;
            }


            if (txtTel.Text == "Telefono" || txtTel.Text == "")
            {
                errorProvider1.SetError(txtTel, "Ingrese su Numero telefonico");
                isOK = false;
            }

            if (txtCorreo.Text == "Correo" || txtCorreo.Text == "")
            {
                errorProvider1.SetError(txtCorreo, "Ingrese su Correo ");
                isOK = false;
            }


            if (txtEdad.Text == "Edad" || txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "Ingrese su edad ");
                isOK = false;
            }


            if (txtDireccion.Text == "Direccion" || txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "Ingrese su Direccion");
                isOK = false;
            }

            if (cmxGenero.Text == "")
            {
                errorProvider1.SetError(cmxGenero, "Seleccione su genero");
                isOK = false;
            }

            if (txtFechaNa.Text == "Fecha  de nacimiento  (AAA-MM-DD)" || txtFechaNa.Text == "")
            {
                errorProvider1.SetError(txtFechaNa, "Ingrese su Fecha de nacimiento");
                isOK = false;
            }


            if (txtRFC.Text == "RFC" || txtRFC.Text == "")
            {
                errorProvider1.SetError(txtRFC, "Ingrese su RFC");
                isOK = false;
            }


            if (txtReferencia1.Text == "Nombre" || txtReferencia1.Text == "")
            {
                errorProvider1.SetError(txtReferencia1, "Ingrese El nombre se su Referencia");
                isOK = false;
            }


            if (txtNumR1.Text == "Telefono" || txtNumR1.Text == "")
            {
                errorProvider1.SetError(txtNumR1, "Ingrese el numero telefonico se su Referencia");
                isOK = false;
            }


            if (txtReferencia2.Text == "Nombre" || txtReferencia2.Text == "")
            {
                errorProvider1.SetError(txtReferencia2, "Ingrese El nombre se su Referencia");
                isOK = false;
            }


            if (txtNumR2.Text == "Telefono" || txtNumR2.Text == "")
            {
                errorProvider1.SetError(txtNumR2, "Ingrese el numero telefonico se su Referencia");
                isOK = false;
            }

            if (txtReferencia3.Text == "Nombre" || txtReferencia3.Text == "")
            {
                errorProvider1.SetError(txtReferencia3, "Ingrese El nombre se su Referencia");
                isOK = false;
            }


            if (txtNumR3.Text == "Telefono" || txtNumR3.Text == "")
            {
                errorProvider1.SetError(txtNumR3, "Ingrese el numero telefonico se su Referencia");
                isOK = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Clientes clientes = new Clientes();
            clientes.CerrarPanel();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ValidacionRegistro())
            {
                try
                {
                    //  Nombre, Apellidos,password, Telefono, Correo, Edad, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3
                    objetoCliente.InsertarCliente(txtNombre.Text, txtApellidos.Text, txtPassword.Text, txtTel.Text, txtCorreo.Text, txtEdad.Text, txtDireccion.Text, cmxGenero.Text, txtFechaNa.Text, txtRFC.Text, txtReferencia1.Text, txtNumR1.Text, txtReferencia2.Text, txtNumR2.Text, txtReferencia3.Text, txtNumR3.Text);
                    MessageBox.Show("Registro Realizado con exito");
                    Clientes panel = new Clientes();

                    txtNombre.Text = "Nombre";
                    txtNombre.ForeColor = Color.Gray;
                    txtApellidos.Text = "Apellidos";
                    txtApellidos.ForeColor = Color.Gray;
                    txtCorreo.Text = "Correo";
                    txtCorreo.ForeColor = Color.Gray;
                    txtPassword.Text = "Contraseña";
                    txtPassword.ForeColor = Color.Gray;
                    txtEdad.Text = "Edad";
                    txtEdad.ForeColor = Color.Gray;
                    txtDireccion.Text = "Direccion";
                    txtDireccion.ForeColor = Color.Gray;
                    txtTel.Text = "Telefono";
                    txtTel.ForeColor = Color.Gray;
                    cmxGenero.Text = "";
                    cmxGenero.ForeColor = Color.Gray;
                    txtReferencia1.Text = "Nombre";
                    txtReferencia1.ForeColor = Color.Gray;
                    txtRFC.Text = "RFC";
                    txtRFC.ForeColor = Color.Gray;
                    txtReferencia2.Text = "Nombre";
                    txtReferencia2.ForeColor = Color.Gray;
                    txtReferencia3.Text = "Nombre";
                    txtReferencia3.ForeColor = Color.Gray;
                    txtNumR1.Text = "Telefono";
                    txtNumR1.ForeColor = Color.Gray;
                    txtNumR2.Text = "Telefono";
                    txtNumR2.ForeColor = Color.Gray;
                    txtNumR3.Text = "Telefono";
                    txtNumR3.ForeColor = Color.Gray;
                    txtFechaNa.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
                    txtFechaNa.ForeColor = Color.Gray;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }

        private bool ValidacionRegistro()
        {
            bool isOK = true;
            if (txtNombre.Text == "Nombre" || txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese su Nombre");
                isOK = false;
            }


            if (txtApellidos.Text == "Apellidos" || txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese sus Apellidos");
                isOK = false;
            }


            if (txtPassword.Text == "Contraseña" || txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Establesca una contraseña");
                isOK = false;
            }


            if (txtTel.Text == "Telefono" || txtTel.Text == "")
            {
                errorProvider1.SetError(txtTel, "Ingrese su Numero telefonico");
                isOK = false;
            }

            if (txtCorreo.Text == "Correo" || txtCorreo.Text == "")
            {
                errorProvider1.SetError(txtCorreo, "Ingrese su Correo ");
                isOK = false;
            }


            if (txtEdad.Text == "Edad" || txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "Ingrese su edad ");
                isOK = false;
            }


            if (txtDireccion.Text == "Direccion" || txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "Ingrese su Direccion");
                isOK = false;
            }

            if (cmxGenero.Text == "")
            {
                errorProvider1.SetError(cmxGenero, "Seleccione su genero");
                isOK = false;
            }

            if (txtFechaNa.Text == "Fecha  de nacimiento  (AAA-MM-DD)" || txtFechaNa.Text == "")
            {
                errorProvider1.SetError(txtFechaNa, "Ingrese su Fecha de nacimiento");
                isOK = false;
            }


            if (txtRFC.Text == "RFC" || txtRFC.Text == "")
            {
                errorProvider1.SetError(txtRFC, "Ingrese su RFC");
                isOK = false;
            }


            if (txtReferencia1.Text == "Nombre" || txtReferencia1.Text == "")
            {
                errorProvider1.SetError(txtReferencia1, "Ingrese El nombre se su Referencia");
                isOK = false;
            }


            if (txtNumR1.Text == "Telefono" || txtNumR1.Text == "")
            {
                errorProvider1.SetError(txtNumR1, "Ingrese el numero telefonico se su Referencia");
                isOK = false;
            }


            if (txtReferencia2.Text == "Nombre" || txtReferencia2.Text == "")
            {
                errorProvider1.SetError(txtReferencia2, "Ingrese El nombre se su Referencia");
                isOK = false;
            }


            if (txtNumR2.Text == "Telefono" || txtNumR2.Text == "")
            {
                errorProvider1.SetError(txtNumR2, "Ingrese el numero telefonico se su Referencia");
                isOK = false;
            }

            if (txtReferencia3.Text == "Nombre" || txtReferencia3.Text == "")
            {
                errorProvider1.SetError(txtReferencia3, "Ingrese El nombre se su Referencia");
                isOK = false;
            }


            if (txtNumR3.Text == "Telefono" || txtNumR3.Text == "")
            {
                errorProvider1.SetError(txtNumR3, "Ingrese el numero telefonico se su Referencia");
                isOK = false;
            }




            return isOK;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Gray;
            txtApellidos.Text = "Apellidos";
            txtApellidos.ForeColor = Color.Gray;
            txtCorreo.Text = "Correo";
            txtCorreo.ForeColor = Color.Gray;
            txtPassword.Text = "Contraseña";
            txtPassword.ForeColor = Color.Gray;
            txtEdad.Text = "Edad";
            txtEdad.ForeColor = Color.Gray;
            txtDireccion.Text = "Direccion";
            txtDireccion.ForeColor = Color.Gray;
            txtTel.Text = "Telefono";
            txtTel.ForeColor = Color.Gray;
            cmxGenero.Text = "";
            cmxGenero.ForeColor = Color.Gray;
            txtReferencia1.Text = "Nombre";
            txtReferencia1.ForeColor = Color.Gray;
            txtRFC.Text = "RFC";
            txtRFC.ForeColor = Color.Gray;
            txtReferencia2.Text = "Nombre";
            txtReferencia2.ForeColor = Color.Gray;
            txtReferencia3.Text = "Nombre";
            txtReferencia3.ForeColor = Color.Gray;
            txtNumR1.Text = "Telefono";
            txtNumR1.ForeColor = Color.Gray;
            txtNumR2.Text = "Telefono";
            txtNumR2.ForeColor = Color.Gray;
            txtNumR3.Text = "Telefono";
            txtNumR3.ForeColor = Color.Gray;
            txtFechaNa.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
            txtFechaNa.ForeColor = Color.Gray;
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
    }
}
