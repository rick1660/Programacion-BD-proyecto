using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD;


namespace ProyectoBD
{
    public partial class ActualizacionRefaccion : Form
    {
        public ActualizacionRefaccion()
        {
            InitializeComponent();
        }



        Consulta2 objetoRefaccion = new Consulta2();
        private string IdEmpleado = null;


        private void MostrarRefaccion()
        {

            Consulta2 objeto = new Consulta2();
            DataGActualizar.DataSource = objeto.MostrarRefaccion();
        }




        private void ActualizacionRefaccion_Load(object sender, EventArgs e)
        {
            MostrarRefaccion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoRefaccion.EditarRefaccion(txtIdRefaccion.Text, txtNombre.Text, txtCosto.Text, txtFechaE.Text, txtFechaS.Text, txtDepart.Text);
                ;
                MessageBox.Show("* Se edito correctamente *");
                MostrarRefaccion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DataGActualizar.SelectedRows.Count > 0)
            {
                txtIdRefaccion.Text = DataGActualizar.CurrentRow.Cells["IdRefaccion"].Value.ToString();
                txtNombre.Text = DataGActualizar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCosto.Text = DataGActualizar.CurrentRow.Cells["Costo"].Value.ToString();
                txtFechaE.Text = DataGActualizar.CurrentRow.Cells["FEntrada"].Value.ToString();
                txtFechaS.Text = DataGActualizar.CurrentRow.Cells["FSalida"].Value.ToString();
                txtDepart.Text = DataGActualizar.CurrentRow.Cells["IdDepartamento"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
