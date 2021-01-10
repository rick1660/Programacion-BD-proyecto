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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }

        private void MostrarEmpleado()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbEmpleados.DataSource = objetoMostrar.MostrarEmpleados();
        }

        private void lblAutos_Click(object sender, EventArgs e)
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgbEmpleados.SelectedRows.Count > 0)
            {

                txtNombre.ForeColor = Color.Black;
                txtApellidos.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtPassword.ForeColor = Color.Black;
                txtFechaNa.ForeColor = Color.Black;
                txtFechaIngreso.ForeColor = Color.Black;
                txtTel.ForeColor = Color.Black;

                txtNombre.Text = dgbEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = dgbEmpleados.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtCorreo.Text = dgbEmpleados.CurrentRow.Cells["Correo"].Value.ToString();
                txtPassword.Text = dgbEmpleados.CurrentRow.Cells["PasswordEmpleado"].Value.ToString();
                txtFechaNa.Text = dgbEmpleados.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                txtFechaIngreso.Text = dgbEmpleados.CurrentRow.Cells["FechaIngreso"].Value.ToString();
                txtTel.Text = dgbEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();


            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void txtFechaNa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeparador8_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Consultas2 objetoCliente = new Consultas2();
            try
            {



                objetoCliente.EditarEmpleado(txtNombre.Text, txtApellidos.Text, txtCorreo.Text, txtPassword.Text, txtFechaNa.Text, txtFechaIngreso.Text, txtTel.Text);
                MessageBox.Show("* Se edito correctamente *");
                MostrarEmpleado();


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }
    }
}
