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
    public partial class ActualizacionEmpleado : Form
    {
        public ActualizacionEmpleado()
        {
            InitializeComponent();
        }


        Consulta2 objetoEmpleado = new Consulta2();
        private string IdEmpleado = null;


        private void MostrarEmpleado()
        {

            Consulta2 objeto = new Consulta2();
            DataGActualizar.DataSource = objeto.MostrarEmpleado();
        }




        private void ActualizacionEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DataGActualizar.SelectedRows.Count > 0)
            {
                txtEmpleado.Text = DataGActualizar.CurrentRow.Cells["IdEmpleado"].Value.ToString();
                txtNombre.Text = DataGActualizar.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTelef.Text = DataGActualizar.CurrentRow.Cells["Telefono"].Value.ToString();
                txtIdDepar.Text = DataGActualizar.CurrentRow.Cells["IdDepartamento"].Value.ToString();
                txtIdVehiculo.Text = DataGActualizar.CurrentRow.Cells["IdVehiculo"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoEmpleado.EditarEmpleado(txtEmpleado.Text, txtNombre.Text, txtTelef.Text, txtIdDepar.Text, txtIdVehiculo.Text );
                MessageBox.Show("* Se edito correctamente *");
                MostrarEmpleado();

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo editar los datos por: " + ex);
            }
        }
    }
}
