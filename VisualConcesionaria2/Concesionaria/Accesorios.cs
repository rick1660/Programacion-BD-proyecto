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
    public partial class Accesorios : Form
    {
        public Accesorios()
        {
            InitializeComponent();
        }

        Consultas2 objetoCliente = new Consultas2();
        private string IdAutopartes = null;

        private void MostrarAccesorios()
        {

            Consultas2 objetoMostrar = new Consultas2();
            dgbAccesorios.DataSource = objetoMostrar.MostrarAccesorios();
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
            AbrirFormEnPanel1(new AgregarAccesorio());
            this.panel.Visible = true;
        }

        private void Accesorios_Load(object sender, EventArgs e)
        {
            MostrarAccesorios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgbAccesorios.SelectedRows.Count > 0)
            {
                IdAutopartes = dgbAccesorios.CurrentRow.Cells["IdAutopartes"].Value.ToString();
                objetoCliente.EliminarAccesorio(IdAutopartes);
                MessageBox.Show("Eliminado correctamente");
                MostrarAccesorios();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel1(new ModificarAccesorio());
            this.panel.Visible = true;
        }
    }
}
