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
    public partial class AltaAutomovil : Form
    {

        Consulta2 objetoAuto = new Consulta2();

        private bool Editar = false;


        public AltaAutomovil()
        {
            InitializeComponent();
        }
        private void MostrarAutomovil()
        {

            Consulta2 objeto = new Consulta2();
            DataGAlta.DataSource = objeto.MostrarAutomovil();
        }
        private void AltaAutomovil_Load(object sender, EventArgs e)
        {
            MostrarAutomovil();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoAuto.InsertarAutomovil(txtVehiculo.Text, txtSerie.Text, txtMarca.Text, txtModelo.Text, txtAño.Text, txtColor.Text, txtFechaR.Text, txtCliente.Text);
                    MessageBox.Show("Datos Insertados Correctamente");
                    MostrarAutomovil();
                    //limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Insertaron Datos");
                }
            }
        }
    }
}
