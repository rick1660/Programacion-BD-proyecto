using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Kardex : Form
    {
        int Usuario;
        public Kardex(int id)
        {
            InitializeComponent();
            Usuario = id;
        }
        SQlConexion SQL = new SQlConexion();
        private void Kardex_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SQL.Kardex(Usuario);
        }
    }
}
