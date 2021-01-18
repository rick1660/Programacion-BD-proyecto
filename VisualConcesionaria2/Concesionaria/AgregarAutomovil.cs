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
    public partial class AgregarAutomovil : Form
    {
        public AgregarAutomovil()
        {
            InitializeComponent();
        }

       

        private bool ValidacionRegistro()
        {
            bool isOK = true;
            if (txtMarca.Text == "Marca" || txtMarca.Text == "")
            {
                errorProvider1.SetError(txtMarca, "Ingrese la marca del automovil");
                isOK = false;
            }


            if (txtModelo.Text == "Modelo" || txtModelo.Text == "")
            {
                errorProvider1.SetError(txtModelo, "Ingrese el modelo del automovil");
                isOK = false;
            }


            if (txtColor.Text == "Color" || txtColor.Text == "")
            {
                errorProvider1.SetError(txtColor, "Ingrese el color del automovil");
                isOK = false;
            }




            if (txtAño.Text == "Telefono" || txtAño.Text == "")
            {
                errorProvider1.SetError(txtAño, "Ingrese el año del automovil");
                isOK = false;
            }

            if (txtSerie.Text == "Correo" || txtSerie.Text == "")
            {
                errorProvider1.SetError(txtSerie, "Ingrese la serie el automovil ");
                isOK = false;
            }

            if (txtFechaIngreso.Text == "Fecha de ingreso (AAA-MM-DD)" || txtFechaIngreso.Text == "")
            {
                errorProvider1.SetError(txtFechaIngreso, "Ingrese la fecha de ingreso");
                isOK = false;
            }


            if (txtFechaIngreso.Text == "Fecha  de ingreso  (AAA-MM-DD)" || txtFechaIngreso.Text == "")
            {
                errorProvider1.SetError(txtFechaIngreso, "Ingrese su Fecha de nacimiento");
                isOK = false;
            }

            return isOK;
        }


        Consultas2 objetoCliente = new Consultas2();


       
        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ValidacionRegistro())
            {
                try
                {
                    //  Nombre, Apellidos,password, Telefono, Correo, Edad, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3
                    objetoCliente.InsertarAuto(txtMarca.Text, txtModelo.Text, txtColor.Text, txtAño.Text, txtSerie.Text, txtFechaIngreso.Text, txtPrecioCompra.Text, txtPrecioVenta.Text);
                    MessageBox.Show("Registro Realizado con exito");

                    txtMarca.Text = "Marca";
                    txtMarca.ForeColor = Color.Gray;
                    txtModelo.Text = "Modelo";
                    txtModelo.ForeColor = Color.Gray;
                    txtColor.Text = "Color";
                    txtColor.ForeColor = Color.Gray;
                    txtAño.Text = "Año";
                    txtAño.ForeColor = Color.Gray;
                    txtSerie.Text = "Serie";
                    txtSerie.ForeColor = Color.Gray;
                    txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
                    txtFechaIngreso.ForeColor = Color.Gray;
                    txtPrecioCompra.Text = "Precio de compra";
                    txtPrecioCompra.ForeColor = Color.Gray;
                    txtPrecioVenta.Text = "Precio venta";
                    txtPrecioVenta.ForeColor = Color.Gray;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos" + ex);
                }
            }
        }

        private void AgregarAutomovil_Load(object sender, EventArgs e)
        {

        }


        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.Gray;
            }
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

        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (txtColor.Text == "Color")
            {
                txtColor.Text = "";
                txtColor.ForeColor = Color.Black;
            }
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "Color";
                txtColor.ForeColor = Color.Gray;
            }
        }

        private void txtAño_Enter(object sender, EventArgs e)
        {
            if (txtAño.Text == "Año")
            {
                txtAño.Text = "";
                txtAño.ForeColor = Color.Black;
            }
        }

        private void txtAño_Leave(object sender, EventArgs e)
        {
            if (txtAño.Text == "")
            {
                txtAño.Text = "Año";
                txtAño.ForeColor = Color.Gray;
            }
        }

        private void txtSerie_Enter(object sender, EventArgs e)
        {
            if (txtSerie.Text == "Serie")
            {
                txtSerie.Text = "";
                txtSerie.ForeColor = Color.Black;
            }
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            if (txtSerie.Text == "")
            {
                txtSerie.Text = "Serie";
                txtSerie.ForeColor = Color.Gray;
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



        private void txtPrecioCompra_Enter(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "Precio de compra")
            {
                 txtPrecioCompra.Text = "";
                txtPrecioCompra.ForeColor = Color.Black;
            }
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "")
            {
                txtPrecioCompra.Text = "Precio de compra";
                txtPrecioCompra.ForeColor = Color.Gray;
            }
        }


        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "Precio venta")
            {
                txtPrecioVenta.Text = "";
                txtPrecioVenta.ForeColor = Color.Black;
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "")
            {
                txtPrecioVenta.Text = "Precio venta";
                txtPrecioVenta.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            txtMarca.Text = "Marca";
            txtMarca.ForeColor = Color.Gray;
            txtModelo.Text = "Modelo";
            txtModelo.ForeColor = Color.Gray;
            txtColor.Text = "Color";
            txtColor.ForeColor = Color.Gray;
            txtAño.Text = "Año";
            txtAño.ForeColor = Color.Gray;
            txtSerie.Text = "Telefono";
            txtSerie.ForeColor = Color.Gray;
            txtFechaIngreso.Text = "Fecha  de ingreso  (AAA-MM-DD)";
            txtFechaIngreso.ForeColor = Color.Gray;
            txtPrecioCompra.Text = "Precio de compra";
            txtPrecioCompra.ForeColor = Color.Gray;
            txtPrecioVenta.Text = "Precio venta";
            txtPrecioVenta.ForeColor = Color.Gray;
        }
    }
}
