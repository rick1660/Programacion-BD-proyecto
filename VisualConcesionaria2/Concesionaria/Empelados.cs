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
    public partial class Empelados : Form
    {
        public Empelados()
        {
            InitializeComponent();
        }


        Consultas2 objetoCliente = new Consultas2();
        private string IdEmpleados = null;

        private void lblAutos_Click(object sender, EventArgs e)
        {

        }

        private void Empelados_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
        }

        private void MostrarEmpleado()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbEmpleados.DataSource = objetoMostrar.MostrarEmpleados();
        }

        private void dgbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgbEmpleados.SelectedRows.Count > 0)
            {
                IdEmpleados= dgbEmpleados.CurrentRow.Cells["IdEmpleados"].Value.ToString();
                objetoCliente.EliminarEmpleado(IdEmpleados);
                MessageBox.Show("Eliminado correctamente");
                MostrarEmpleado();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new AgregarEmpleado());
            this.panel.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new ModificarEmpleado());
            this.panel.Visible = true;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
