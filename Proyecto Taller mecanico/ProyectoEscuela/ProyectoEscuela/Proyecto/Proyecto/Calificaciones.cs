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
    public partial class Calificaciones : Form
    {
        int Maestro=0;
        public Calificaciones(int Id)
        {
            InitializeComponent();
            Maestro = Id;
        }

        SQlConexion SQl = new SQlConexion();
        private void button1_Click(object sender, EventArgs e)
        {
            string Estado = "";
            if (comboBox1.Text == "Activo")
                Estado = "T";
            else if (comboBox1.Text == "Inactivo")
                Estado = "F";

            if(txtCalificacion.Text!=""&&txtIDAlumno.Text!=""&&Estado!="")
            if(!SQl.ExisteCal(Int32.Parse(txtIDAlumno.Text)))
            {
                    // MessageBox.Show("No Existe");
                    SQl.InsertarCal(Maestro.ToString(),txtIDAlumno.Text,txtCalificacion.Text,Estado);
                    limpiar();
                    Cargar();
            }
            else
            {
                if (SQl.EstadoCal(Int32.Parse(txtIDAlumno.Text)))
                {
                        //MessageBox.Show("Activo");
                        SQl.UpdateCal(Maestro.ToString(), txtCalificacion.Text, Estado,txtIDAlumno.Text);
                        limpiar();
                        Cargar();
                }
                else
                {
                    MessageBox.Show("Este Alumno esta inactivo");
                    txtIDAlumno.Focus();
                }
            }
            

        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        void Cargar()
        {
            dataGridView1.DataSource = SQl.CalMaestro(Maestro);
        }
        void limpiar()
        {
            txtCalificacion.Text = "";
            txtIDAlumno.Text = "";
            comboBox1.Text = "";
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {

            if (txtIDAlumno.Text != "")
            {
                if (SQl.ExisteCal(Int32.Parse(txtIDAlumno.Text)))
                {
                    if (!SQl.EstadoCal(Int32.Parse(txtIDAlumno.Text)))
                    {
                        SQl.BajaCal(Maestro.ToString(), txtIDAlumno.Text);
                        limpiar();
                        Cargar();
                    }
                    
                }
            }
            else
            {

            }
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            string Estado = "";
            if (comboBox1.Text == "Activo")
                Estado = "T";
            else if (comboBox1.Text == "Inactivo")
                Estado = "F";

            if (txtCalificacion.Text != "" && txtIDAlumno.Text != "" && Estado != "")
                if (SQl.ExisteCal(Int32.Parse(txtIDAlumno.Text)))
                {
                    if (!SQl.EstadoCal(Int32.Parse(txtIDAlumno.Text)))
                    {
                        if(SQl.FechaF(Maestro,txtIDAlumno.Text))
                        {
                            SQl.UpdateCal(Maestro.ToString(), txtCalificacion.Text, Estado, txtIDAlumno.Text);
                            SQl.UpdateFecha(Maestro, txtIDAlumno.Text);
                            limpiar();
                            Cargar();
                        }
                        else
                        {
                            MessageBox.Show("Ya no se puede modificar este alumno");
                        }
                    }
                }

        }
    }
}
