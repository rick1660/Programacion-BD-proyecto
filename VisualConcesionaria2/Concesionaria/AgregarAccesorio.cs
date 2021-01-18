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
    public partial class AgregarAccesorio : Form
    {
        public AgregarAccesorio()
        {
            InitializeComponent();
        }

        Consultas2 objetoCliente = new Consultas2();

        private void AgregarAccesorio_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ValidacionRegistro())
            {
                try
                {
                    //  Nombre, Apellidos,password, Telefono, Correo, Edad, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3
                    objetoCliente.InsertarAccesorios(txtNombre.Text, txtModelo.Text,Convert.ToInt32( txtPrecio.Text), txtCantidad.Text);
                    MessageBox.Show("Registro Realizado con exito");

                    txtNombre.Text = "Nombre";
                    txtNombre.ForeColor = Color.Gray;
                    txtModelo.Text = "Modelo";
                    txtModelo.ForeColor = Color.Gray;
                    txtPrecio.Text = "Precio";
                    txtPrecio.ForeColor = Color.Gray;
                     
                    txtCantidad.Text = "Cantidad";
                    txtCantidad.ForeColor = Color.Gray;



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


            if (txtModelo.Text == "Modelo" || txtModelo.Text == "")
            {
                errorProvider1.SetError(txtModelo, "Ingrese el Modelo");
                isOK = false;
            }


            if (txtPrecio.Text == "Precio" || txtPrecio.Text == "")
            {
                errorProvider1.SetError(txtPrecio, "Ingrese el Precio");
                isOK = false;
            }


            if (txtCantidad.Text == "Cantidad" || txtCantidad.Text == "")
            {
                errorProvider1.SetError(txtCantidad, "Ingrese la cantidad");
                isOK = false;
            }

            return isOK;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Gray;
            txtModelo.Text = "Modelo";
            txtModelo.ForeColor = Color.Gray;
            txtPrecio.Text = "Precio";
            txtPrecio.ForeColor = Color.Gray;

            txtCantidad.Text = "Cantidad";
            txtCantidad.ForeColor = Color.Gray;
        }

        private void txtModelo_Enter(object sender, EventArgs e)
        {
            if (txtModelo.Text == "Modelo")
            {
                txtModelo.Text = "";
                txtModelo.ForeColor = Color.Black;
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {

            if (txtModelo.Text == "")
            {
                txtModelo.Text = "Modelo";
                txtModelo.ForeColor = Color.Gray;
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

        private void txtCantidad_Enter(object sender, EventArgs e)
        {

            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
                txtCantidad.ForeColor = Color.Black;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
                txtCantidad.ForeColor = Color.Gray;
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {

            if (txtPrecio.Text == "Precio")
            {
                txtPrecio.Text = "";
                txtPrecio.ForeColor = Color.Black;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Precio";
                txtPrecio.ForeColor = Color.Gray;
            }
        }
    }
}
