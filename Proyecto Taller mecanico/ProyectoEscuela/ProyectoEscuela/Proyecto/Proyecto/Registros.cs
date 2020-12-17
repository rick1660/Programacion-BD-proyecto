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
    public partial class Historial : Form
    {
        int ID;
        public Historial(int id)
        {
            InitializeComponent();
            ID = id;
        }
        SQlConexion SQL = new SQlConexion();
        private void Historial_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            int tabla = comboBox1.SelectedIndex;
            if (tabla == 0)
            {
                dataGridView1.DataSource = SQL.Tabla("TH_acceso");
            }
            else
            {
                dataGridView1.DataSource = SQL.Tabla("TH_clave");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
