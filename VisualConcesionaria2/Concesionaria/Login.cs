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
using System.Data.SqlClient;
using System.Data;



namespace Concesionaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }

        string NombreUsuario;

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            RegistroCliente Registro = new RegistroCliente();
            Registro.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            logear(txtUsuario.Text, txtContraseña.Text);
            //Form1 principal = new Form1();
            //this.Visible=false;
            //principal.Show();
            

        }



       
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-NDLJN6T;DataBase= concesionario;Integrated Security=true");
       
         
     


        //Medoto de validacion de usuario
        public void logear(string Correo, string Contraseña) 
        {
            try 
            {
                Conexion.Open();

                SqlCommand cmd = new SqlCommand("SELECT Nombre , TipoUsuario FROM Clientes WHERE Correo = @Correo AND PasswordCliente = @pas", Conexion);
                cmd.Parameters.AddWithValue("Correo", Correo);
                cmd.Parameters.AddWithValue("Pas", Contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                SqlCommand TAdmin = new SqlCommand("SELECT Nombre , TipoUsuario FROM Administrador WHERE Correo = @Correo AND Contraseña = @pas", Conexion);
                TAdmin.Parameters.AddWithValue("correo", Correo);
                TAdmin.Parameters.AddWithValue("pas", Contraseña);
                SqlDataAdapter Tba = new SqlDataAdapter(TAdmin);
                DataTable Tad = new DataTable();
                Tba.Fill(Tad);


                if (dt.Rows.Count == 1 )
                {
                    this.Hide();
                   if (dt.Rows[0][1].ToString() == "2")
                    {
                        NombreUsuario = dt.Rows[0][0].ToString();
                        new ClienteInterfaz(dt.Rows[0][0].ToString()).Show();
                    }
                  

                }
                else
                if (Tad.Rows.Count == 1)
                {
                    this.Hide();

                    if (Tad.Rows[0][1].ToString() == "3")
                    {
                        NombreUsuario = Tad.Rows[0][0].ToString();
                        new Form1(Tad.Rows[0][0].ToString()).Show();

                    }

                }
                else
                {
                    MessageBox.Show("Correo y/o contraseña incorrecta");
                    Conexion.Close();

                }





            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSeparador1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario") 
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
            }
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
