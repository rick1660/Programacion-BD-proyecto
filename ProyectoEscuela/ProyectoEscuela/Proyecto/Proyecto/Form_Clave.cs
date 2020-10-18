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
    public partial class Form_Clave : Form
    {

        public int ID;
        public Form_Clave(int Id)
        {
            InitializeComponent();
            ID = Id;
        }
        SQlConexion Sql = new SQlConexion();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (Sql.ModificarClave(ID, Int32.Parse(txtCA.Text), Int32.Parse(txtCN.Text)))
            {
                
                Close();
            }
            else {
                MessageBox.Show("No se puede cambiar clave, verifique la informacion");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
