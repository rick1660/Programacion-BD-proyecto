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

namespace Proyecto
{
    public partial class From_Login : Form
    {
        public From_Login()
        {
            InitializeComponent();
        }


        int User; 
        string Password, rol; 

        private void btnagregar1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(System.FormatException)
            {

            }
        }
        
       
      
        private void btnagregardocente_Click(object sender, EventArgs e)
        {
           
        }

       
        
        private void cmd_login_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void From_Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void From_Login_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_login_Click_1(object sender, EventArgs e)
        {
            SQlConexion sql = new SQlConexion();
            int id = Int32.Parse(textBox4.Text);
            int pass = Int32.Parse(textBox1.Text);
            string role = sql.Login(id, pass);
            if (role != "")
            {
                sql.Acceso(id);
                Froma F = new Froma(Int32.Parse(textBox4.Text),role);
                this.Visible = false;
                F.ShowDialog();
                this.Visible = true;
                textBox1.Text = "";
                textBox4.Text = "";

            } else {
                MessageBox.Show("* Contraseña y/o Usuario Incorrecto *");
            }
              
        }

       
    }
}
