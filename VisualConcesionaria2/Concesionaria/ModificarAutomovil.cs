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
    public partial class ModificarAutomovil : Form
    {
        public ModificarAutomovil()
        {
            InitializeComponent();
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


        private void MostrarAutos()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAutos.DataSource = objetoMostrar.MostrarAutos();
        }

        private void ModificarAutomovil_Load(object sender, EventArgs e)
        {
            MostrarAutos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgbAutos.SelectedRows.Count > 0)
            {

                txtMarca.ForeColor = Color.Black;
                txtModelo.ForeColor = Color.Black;
                txtColor.ForeColor = Color.Black;
                txtAño.ForeColor = Color.Black;
                txtSerie.ForeColor = Color.Black;
                txtFechaIngreso.ForeColor = Color.Black;
                txtPrecioCompra.ForeColor = Color.Black;
                txtPrecioVenta.ForeColor = Color.Black;


                txtMarca.Text = dgbAutos.CurrentRow.Cells["Marca"].Value.ToString();
                txtModelo.Text = dgbAutos.CurrentRow.Cells["Modelo"].Value.ToString();
                txtColor.Text = dgbAutos.CurrentRow.Cells["Color"].Value.ToString();
                txtAño.Text = dgbAutos.CurrentRow.Cells["Año"].Value.ToString();
                txtSerie.Text = dgbAutos.CurrentRow.Cells["Serie"].Value.ToString();
                txtFechaIngreso.Text = dgbAutos.CurrentRow.Cells["FechaIngreso"].Value.ToString();
                txtPrecioCompra.Text = dgbAutos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = dgbAutos.CurrentRow.Cells["PrecioVenta"].Value.ToString();



            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Consultas2 objetoCliente = new Consultas2();
            try
            {



                objetoCliente.EditarAutomovil(txtMarca.Text, txtModelo.Text, txtColor.Text, txtAño.Text, txtSerie.Text, txtFechaIngreso.Text, txtPrecioCompra.Text, txtPrecioVenta.Text);
                MessageBox.Show("* Se edito correctamente *");
                MostrarAutos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }
    }
}
