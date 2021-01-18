using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Concesionaria
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        Consultas2 objetoCliente = new Consultas2();

        private void lblAutos_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-NDLJN6T;DataBase= concesionario;Integrated Security=true");
        private void ValidacionExistenciaCorreo(string Correo)
        {
            Conexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT Correo FROM Clientes WHERE Correo=@Correo", Conexion);
            cmd.Parameters.AddWithValue("Correo", Correo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            if (dt.Rows.Count == 1)
            {
                errorProvider2.SetError(txtCorreo, "El correo ya se encuentra registrado, porfavor utilice uno diferente");
                Conexion.Close();

            }
            Conexion.Close();
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
            txtTel.Text = "Telefono";
            txtTel.ForeColor = Color.Gray;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ValidacionRegistro())
            {
                try
                {
                    //  Nombre, Apellidos,password, Telefono, Correo, Edad, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3
                    objetoCliente.InsertarEmpleado(txtNombre.Text, txtApellidos.Text,txtCorreo.Text,txtPassword.Text, txtFechaNa.Text, txtFechaIngreso.Text,txtTel.Text);
                    MessageBox.Show("Registro Realizado con exito");

                    txtNombre.Text = "Nombre";
                    txtNombre.ForeColor = Color.Gray;
                    txtApellidos.Text = "Apellidos";
                    txtApellidos.ForeColor = Color.Gray;
                    txtCorreo.Text = "Correo";
                    txtCorreo.ForeColor = Color.Gray;
                    txtPassword.Text = "Contraseña";
                    txtPassword.ForeColor = Color.Gray;
                    txtFechaNa.Text = "Telefono";
                    txtFechaNa.ForeColor = Color.Gray;
                    txtTel.Text = "Fecha  de nacimiento  (AAA-MM-DD)";
                    txtTel.ForeColor = Color.Gray;
                    txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
                    txtFechaIngreso.ForeColor = Color.Gray;


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

            if (txtFechaNa.Text == "Fecha  de nacimiento  (AAA-MM-DD)" || txtFechaNa.Text == "")
            {
                errorProvider1.SetError(txtFechaNa, "Ingrese su Fecha de nacimiento");
                isOK = false;
            }


            if (txtFechaIngreso.Text == "Fecha  de ingreso  (AAA-MM-DD)" || txtFechaIngreso.Text == "")
            {
                errorProvider1.SetError(txtFechaIngreso, "Ingrese su Fecha de nacimiento");
                isOK = false;
            }

            return isOK;
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

        private void txtFechaIngreso_Enter(object sender, EventArgs e)
        {
            if (txtFechaIngreso.Text == "Fecha  de ingreso  (AAA-MM-DD)")
            {
                txtFechaIngreso.Text = "";
                txtFechaIngreso.ForeColor = Color.Black;
            }
        }

        private void txtFechaIngreso_Leave(object sender, EventArgs e)
        {
            if (txtFechaIngreso.Text == "")
            {
                txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
                txtFechaIngreso.ForeColor = Color.Gray;
            }
        }



        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador8_Click(object sender, EventArgs e)
        {

        }

        private void txtSeparador5_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            if (txtCorreo.Text != "")
            {
                ValidacionExistenciaCorreo(txtCorreo.Text);
            }
        }

        private void txtSeparador8_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFechaIngreso_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSeparador7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFechaNa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSeparador15_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSeparador3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSeparador4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSeparador2_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged_1(object sender, EventArgs e)
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
