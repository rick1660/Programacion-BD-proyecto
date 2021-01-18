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
    public partial class ModificarAccesorio : Form
    {
        public ModificarAccesorio()
        {
            InitializeComponent();
        }

        private void lblAutos_Click(object sender, EventArgs e)
        {

        }

        private void dgbAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void MostrarAccesorioss()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAccesorios.DataSource = objetoMostrar.MostrarAccesorios();
        }

        private void ModificarAccesorio_Load(object sender, EventArgs e)
        {
            MostrarAccesorioss();
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

        private void MostrarAccesorios()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAccesorios.DataSource = objetoMostrar.MostrarAccesorios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Consultas2 objetoCliente = new Consultas2();
            try
            {



                objetoCliente.EditarAccesorio(txtNombre.Text, txtModelo.Text, Convert.ToInt32(txtPrecio.Text),txtCantidad.Text);
                MessageBox.Show("* Se edito correctamente *");
                MostrarAccesorios();
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
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgbAccesorios.SelectedRows.Count > 0)
            {

                txtNombre.ForeColor = Color.Black;
                txtModelo.ForeColor = Color.Black;
                txtPrecio.ForeColor = Color.Black;
                txtCantidad.ForeColor = Color.Black;
                





                txtNombre.Text = dgbAccesorios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtModelo.Text = dgbAccesorios.CurrentRow.Cells["Modelo"].Value.ToString();
                txtPrecio.Text = dgbAccesorios.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text = dgbAccesorios.CurrentRow.Cells["Cantidad"].Value.ToString();


                ValidacionRegistro();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
