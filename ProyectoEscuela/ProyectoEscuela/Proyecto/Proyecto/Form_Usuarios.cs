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
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }


        SQlConexion SQL = new SQlConexion();
        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQL.Maestros();
        }

        private void txtIdusuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Estado="", Sexo="",Rol="";
            if (ComEstado.Text == "Activo")
                Estado = "T";
            else if(ComEstado.Text == "Inactivo")
                Estado = "F";

            if (ComSexo.Text == "Hombre")
                Sexo = "H";
            else if(ComSexo.Text == "Mujer")
                Sexo = "M";

            if (ComRol.Text == "MAESTRO")
                Rol = "MAESTRO";
            else if (ComRol.Text == "ALUMNO")
                Rol = "ALUMNO";


            if (txtIdusuario.Text != "" && txtClave.Text != ""&&txtNombre.Text != ""&&txtApellido.Text!=""&&Sexo!=""&&Estado!=""&&Rol!="")
            {
                if (SQL.Insertar(Convert.ToInt32(txtIdusuario.Text), Convert.ToInt32(txtClave.Text), Sexo, Estado, txtNombre.Text, txtApellido.Text, Rol))
                {
                    MessageBox.Show("Datos insertados");
                    dataGridView1.DataSource = SQL.Maestros();

                }
                else MessageBox.Show("No se han podido insertar los datos");

                ComEstado.Text = "";
                txtApellido.Text = "";
                txtClave.Text = "";
                txtIdusuario.Text = "";
                txtNombre.Text = "";
                ComRol.Text = "";
                ComSexo.Text = "";
            }
            else MessageBox.Show("Datos No Validos");
        }

        private void txtIdusuario_Leave(object sender, EventArgs e)
        {
            if(SQL.Existe(Int32.Parse(txtIdusuario.Text)))
            {
                MessageBox.Show("Ese Id ya esta en uso");
                txtIdusuario.Focus();
            }
            else
            {

            }
        }

        private void RESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       /* private void RespaldoTools_Click(object sender, EventArgs e)
        {
            string Respaldo = (System.DateTime.Today.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System..DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "Respaldo");
        }*/
    }
}
