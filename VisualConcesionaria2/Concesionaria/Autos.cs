using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionaria
{
    public partial class Autos : Form
    {

        Consultas2 objetoCliente = new Consultas2();
        private string IdAutomovil = null;
        public Autos()
        {
            InitializeComponent();
        }

        private void Autos_Load(object sender, EventArgs e)
        {
            MostrarAutos();
        }

        private void lblAutos_Click(object sender, EventArgs e)
        {

        }

        private void MostrarAutos()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAutos.DataSource = objetoMostrar.MostrarAutos();
        }

        public void AbrirFormEnPanel1(object Formhijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }


        private void dgbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new AgregarAutomovil());
            this.panel.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgbAutos.SelectedRows.Count > 0)
            {
                IdAutomovil = dgbAutos.CurrentRow.Cells["IdAutomovil"].Value.ToString();
                objetoCliente.EliminarAutomovil(IdAutomovil);
                MessageBox.Show("Eliminado correctamente");
                MostrarAutos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new ModificarAutomovil());
            this.panel.Visible = true;
        }
    }
}
