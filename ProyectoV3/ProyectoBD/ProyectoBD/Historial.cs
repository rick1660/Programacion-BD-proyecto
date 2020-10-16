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

using ProyectoBD;


namespace ProyectoBD
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void MostrarHistorial()
        {

            Consulta2 objeto = new Consulta2();
            DataGHistorial.DataSource = objeto.MostrarHistorial();
        }


        private void Historial_Load(object sender, EventArgs e)
        {
            MostrarHistorial();
        }


    }
}
