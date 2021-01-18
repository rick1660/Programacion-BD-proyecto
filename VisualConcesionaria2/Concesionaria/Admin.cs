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
    public partial class Admin : Form
    {
        string RutaImgAtual;
        public Admin()
        {
            InitializeComponent();
        }

        private void Administrador_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*,png|GIF (*.gif)|*.gif";

            if(getImage.ShowDialog() == DialogResult.OK) 
            {
                //ptxPerfil.ImageLocation = getImage.FileName;
                txtRuta.Text = getImage.FileName;
                RutaImgAtual = getImage.FileName;
                 ptxPerfil.ImageLocation = getImage.FileName;
                Consultas2 inserccion = new Consultas2();
                inserccion.EliminarRuta();

                inserccion.InsertarRuta(RutaImgAtual);

               
            }
            else 
            {
                MessageBox.Show("No se selecciono imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-NDLJN6T;DataBase= concesionario;Integrated Security=true");

        private void Admin_Load(object sender, EventArgs e)
        {
            MostrarAdmiiin();

            //datagridview.SelectedRows[0].Index


            ConsultarInfo();

            SqlCommand cmd = new SqlCommand("SELECT Ruta FROM RutaImg WHERE idRuta = 1", Conexion);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

           


            if (dt.Rows.Count == 1)
            {
                ptxPerfil.ImageLocation = dt.Rows[0][0].ToString();


            }

        }

        private void ConsultarInfo() 
        {
            txtIdAdmin.Text = dgbAdministrador.CurrentRow.Cells["IdAdministrador"].Value.ToString();
            txtNombre.Text = dgbAdministrador.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDireccion.Text = dgbAdministrador.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgbAdministrador.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dgbAdministrador.CurrentRow.Cells["Correo"].Value.ToString();
            txtContraseña.Text = dgbAdministrador.CurrentRow.Cells["Contraseña"].Value.ToString();
            txtFechaIngreso.Text = dgbAdministrador.CurrentRow.Cells["FechaIngreso"].Value.ToString();
        }

        private void MostrarAdmiiin()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAdministrador.DataSource = objetoMostrar.MostrarAdmin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas2 objetoCliente = new Consultas2();
            try
            {



                objetoCliente.EditarAdmin(Convert.ToInt32(txtIdAdmin.Text),txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text,txtFechaIngreso.Text);
                MessageBox.Show("* Se edito correctamente *");
                ConsultarInfo();
                txtNombre.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtCorreo.ReadOnly = true;
                txtContraseña.ReadOnly = true;
                txtFechaIngreso.ReadOnly = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtNombre.ReadOnly == true) 
            {
                txtNombre.ReadOnly = false;
                txtDireccion.ReadOnly = false;
                txtTelefono.ReadOnly = false;
                txtCorreo.ReadOnly = false;
                txtContraseña.ReadOnly = false;
                txtFechaIngreso.ReadOnly = false;

                txtNombre.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.Black;
                txtTelefono.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.Black;
                txtFechaIngreso.ForeColor = Color.Black;
            }
            else 
            {
                txtNombre.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtCorreo.ReadOnly = true;
                txtContraseña.ReadOnly = true;
                txtFechaIngreso.ReadOnly = true;
            }
           
                //.CharacterCasing = CharacterCasing.Normal;
        }
    }

        

       
    
}
