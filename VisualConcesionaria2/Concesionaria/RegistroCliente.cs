using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Concesionaria
{
    public partial class RegistroCliente : Form
    {

        Consultas2 objetoCliente = new Consultas2();
        public RegistroCliente()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void ptxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    this.Close();
                    Login Sesion = new Login();
                    Sesion.Show();
                    

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


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

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

        private void lblGenero_Click(object sender, EventArgs e)
        {

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

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if(txtDireccion.Text == "Direccion")
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

        private void RegistroCliente_Shown(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtNombre.Text == "Nombre") 
            {

            }

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador15_Click(object sender, EventArgs e)
        {

        }

        private void txtSeparador5_Click(object sender, EventArgs e)
        {

        }

        private void txtSeparador13_Click(object sender, EventArgs e)
        {

        }

        private void txtNumR3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador14_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador10_Click(object sender, EventArgs e)
        {

        }

        private void txtNumR2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador12_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador11_Click(object sender, EventArgs e)
        {

        }

        private void txtNumR1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador9_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador8_Click(object sender, EventArgs e)
        {

        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador7_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaNa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador6_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador3_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador4_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador2_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
