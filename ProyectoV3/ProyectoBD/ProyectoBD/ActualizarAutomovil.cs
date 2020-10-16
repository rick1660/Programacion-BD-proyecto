using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class ActualizarAutomovil : Form
    {
        public ActualizarAutomovil()
        {
            InitializeComponent();
        }



        Consulta2 objetoAutomovil = new Consulta2();
        private string IdEmpleado = null;


        private void MostrarAutomovil()
        {

            Consulta2 objeto = new Consulta2();
            DataGActualizar.DataSource = objeto.MostrarAutomovil();
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoAutomovil.EditarAutomovil(txtVehiculo.Text, txtSerie.Text, txtMarca.Text, txtModelo.Text, txtAño.Text, txtColor.Text, txtFechaR.Text, txtCliente.Text);
                MessageBox.Show("* Se edito correctamente *");
                MostrarAutomovil();


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
                txtVehiculo.Text = DataGActualizar.CurrentRow.Cells["IdVehiculo"].Value.ToString();
                txtSerie.Text = DataGActualizar.CurrentRow.Cells["NumSerie"].Value.ToString();
                txtMarca.Text = DataGActualizar.CurrentRow.Cells["Marca"].Value.ToString();
                txtModelo.Text = DataGActualizar.CurrentRow.Cells["Modelo"].Value.ToString();
                txtAño.Text = DataGActualizar.CurrentRow.Cells["Color"].Value.ToString();
                txtColor.Text = DataGActualizar.CurrentRow.Cells["Año"].Value.ToString();
                txtFechaR.Text = DataGActualizar.CurrentRow.Cells["Feche_Registro"].Value.ToString();
                txtCliente.Text = DataGActualizar.CurrentRow.Cells["IdCliente"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void ActualizarAutomovil_Load(object sender, EventArgs e)
        {
            MostrarAutomovil();
        }
    }
}
