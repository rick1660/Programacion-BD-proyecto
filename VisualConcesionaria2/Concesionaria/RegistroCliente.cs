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
            if (txtNombre.Text == "NOMBRES")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRES";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {

            if (txtApellidos.Text == "APELLIDOS")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.Black;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "APELLIDOS";
                txtApellidos.ForeColor = Color.Gray;
            }
        }

        private void textTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "TELEFONO")
            {
                txtTel.Text = "";
                txtTel.ForeColor = Color.Black;
            }
        }

        private void textTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "TELEFONO";
                txtTel.ForeColor = Color.Gray;
            }
        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "CORREO";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void textEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "EDAD")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;
            }
        }

        private void textEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD";
                txtEdad.ForeColor = Color.Gray;
            }
        }

        private void textSexo_Enter(object sender, EventArgs e)
        {
            if (txtSexo.Text == "GENERO")
            {
                txtSexo.Text = "";
                txtSexo.ForeColor = Color.Black;
            }
        }

        private void textSexo_Leave(object sender, EventArgs e)
        {
            if (txtSexo.Text == "")
            {
                txtSexo.Text = "GENERO";
                txtSexo.ForeColor = Color.Gray;
            }
        }

        private void txtFechaNa_Enter(object sender, EventArgs e)
        {
            if (txtFechaNa.Text == "FECHA DE NACIMIENTO  (AAA-MM-DD)")
            {
                txtFechaNa.Text = "";
                txtFechaNa.ForeColor = Color.Black;
            }
        }

        private void txtFechaNa_Leave(object sender, EventArgs e)
        {
            if (txtFechaNa.Text == "")
            {
                txtFechaNa.Text = "FECHA DE NACIMIENTO  (AAA-MM-DD)";
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
            if (txtReferencia1.Text == "REFERENCIA 1")
            {
                txtReferencia1.Text = "";
                txtReferencia1.ForeColor = Color.Black;
            }
        }

        private void textReferencia1_Leave(object sender, EventArgs e)
        {
            if (txtReferencia1.Text == "")
            {
                txtReferencia1.Text = "REFERENCIA 1";
                txtReferencia1.ForeColor = Color.Gray;
            }
        }

        private void textNumR1_Enter(object sender, EventArgs e)
        {
            if (txtNumR1.Text == "NUMERO DE REFERENCIA 1")
            {
                txtNumR1.Text = "";
                txtNumR1.ForeColor = Color.Black;
            }
        }

        private void textNumR1_Leave(object sender, EventArgs e)
        {
            if (txtNumR1.Text == "")
            {
                txtNumR1.Text = "NUMERO DE REFERENCIA 1";
                txtNumR1.ForeColor = Color.Gray;
            }
        }

        private void textReferencia2_Enter(object sender, EventArgs e)
        {
            if (txtReferencia2.Text == "REFERENCIA 2")
            {
                txtReferencia2.Text = "";
                txtReferencia2.ForeColor = Color.Black;
            }
        }

        private void textReferencia2_Leave(object sender, EventArgs e)
        {
            if (txtReferencia2.Text == "")
            {
                txtReferencia2.Text = "REFERENCIA 2";
                txtReferencia2.ForeColor = Color.Gray;
            }
        }

        private void textNumR2_Enter(object sender, EventArgs e)
        {
            if (txtNumR2.Text == "NUMERO DE REFERENCIA 2")
            {
                txtNumR2.Text = "";
                txtNumR2.ForeColor = Color.Black;
            }
        }

        private void textNumR2_Leave(object sender, EventArgs e)
        {
            if (txtNumR2.Text == "")
            {
                txtNumR2.Text = "NUMERO DE REFERENCIA 2";
                txtNumR2.ForeColor = Color.Gray;
            }
        }

        private void textNumR3_Enter(object sender, EventArgs e)
        {
            if (txtNumR3.Text == "NUMERO DE REFERENCIA 3")
            {
                txtNumR3.Text = "";
                txtNumR3.ForeColor = Color.Black;
            }
        }

        private void textNumR3_Leave(object sender, EventArgs e)
        {
            if (txtNumR3.Text == "")
            {
                txtNumR3.Text = "NUMERO DE REFERENCIA 3";
                txtNumR3.ForeColor = Color.Gray;
            }
        }

        private void txtReferencia3_Enter(object sender, EventArgs e)
        {
            if (txtReferencia3.Text == "REFERENCIA 3")
            {
                txtReferencia3.Text = "";
                txtReferencia3.ForeColor = Color.Black;
            }
        }

        private void txtReferencia3_Leave(object sender, EventArgs e)
        {
            if (txtReferencia3.Text == "")
            {
                txtReferencia3.Text = "REFERENCIA 3";
                txtReferencia3.ForeColor = Color.Gray;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                                              //  Nombre, Apellidos, Telefono, Correo, Edad, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3
                objetoCliente.InsertarCliente(txtNombre.Text, txtApellidos.Text,txtPassword.Text, txtTel.Text, txtCorreo.Text, txtEdad.Text, txtSexo.Text, txtFechaNa.Text, txtRFC.Text, txtReferencia1.Text, txtNumR1.Text, txtReferencia2.Text, txtNumR2.Text, txtReferencia3.Text, txtNumR3.Text);
                MessageBox.Show("Datos Insertados Correctamente");
              
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Insertaron Datos" + ex);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
