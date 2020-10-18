using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


// DLL que permite los ajustes de la Form
using System.Runtime.InteropServices;
namespace Proyecto
{
    public partial class Froma : Form
    {
        // Variables y componentes locales
        private CircularProgressBar.CircularProgressBar CPB = new CircularProgressBar.CircularProgressBar();
        public bool llave = true;
        private Form froma;
        private int procentaje = 0;

        string role;
        int id;

        public Froma(int ID,string Role)
        {


            InitializeComponent();
            PanelP.Visible = false;
            PanelBar.Visible = false;
            Generar_CPB();
            id = ID;
            role = Role;
            //panel2.BackColor = Color.FromArgb(100,88, 44, 55);
        }
        
        


        // Para Arastrar el from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);

        // Metodo que genera un CircularProgressBar 
        public void Generar_CPB() {
            CPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            CPB.AnimationSpeed = 100;
            CPB.BackColor = System.Drawing.Color.Transparent;
            CPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CPB.ForeColor = System.Drawing.Color.White;
            CPB.InnerColor = System.Drawing.Color.Transparent;
            CPB.InnerMargin = 2;
            CPB.InnerWidth = -1;
            CPB.Location = new System.Drawing.Point(311, 116);
            CPB.MarqueeAnimationSpeed = 2000;
            CPB.Name = "CPB";
            CPB.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            CPB.OuterMargin = -25;
            CPB.OuterWidth = 25;
            CPB.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            CPB.ProgressWidth = 15;
            CPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CPB.Size = new System.Drawing.Size(373, 364);
            CPB.StartAngle = 270;
            CPB.SubscriptColor = System.Drawing.Color.White;
            CPB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            CPB.SubscriptText = "";
            CPB.SuperscriptColor = System.Drawing.Color.White;
            CPB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            CPB.SuperscriptText = "%";
            CPB.TabIndex = 0;
            CPB.Text = "0";
            CPB.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            CPB.Value = 0;
            Controls.Add(CPB);
        }

        
        // Metodo donde inica 
        public void Inciar() {
            froma = new From_Inicio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PanelP.Controls.Add(froma);
            btnIniciar.BackColor = Color.FromArgb(0, 80, 100);
            froma.Show();

            switch (role) {
                case "ALUMNO":
                    btnMaestra.Visible = false;
                    btnConsulta.Visible = false;
                    btnHistorial.Visible = false;
                    panel3.Visible = false;
                    break;
                case "MAESTRO":
                    btnMaestra.Visible = false;
                    btnKardex.Visible = false;
                    btnHistorial.Visible = false;
                    panel3.Visible = false;
                    break;
                case "ADMIN":
                    btnConsulta.Visible = false;
                    btnKardex.Visible = false;
                    break;
               
            }

        }

        // Metodo donde se cambia el color los botones
        public void Cambio_botones(){
            btnHistorial.BackColor = Color.Transparent;
            btnIniciar.BackColor = Color.Transparent;
            btnKardex.BackColor = Color.Transparent;
    }
        // Donde podemos mover la ventana 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelMV_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
       // Cierra la aplicacion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelP.Controls.Clear();
            Close();
        }

        // Minizar la aplicacion
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void PanelP_Paint(object sender, PaintEventArgs e)
        {

        }
        // Boton de Generar
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Type t = froma.GetType();
            if (!(t.Equals(typeof(Kardex))))
            {
                Cambio_botones();
                froma.Close();
                froma = new Kardex(id)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                PanelP.Controls.Add(froma);
                btnConsulta.BackColor = Color.FromArgb(0, 80, 100);
                froma.Show();
            }

        }
        // Boton de Inicio
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Cambio_botones();
            froma.Close();
            Inciar();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CPB.Value = procentaje;
            CPB.Text = CPB.Value.ToString();
            if (procentaje == 100) {
                CPB.Visible = false;
                PanelMV.Visible = true;
                PanelP.Visible = true;
                PanelBar.Visible = true;
                timer1.Enabled = false;
                timer1.Stop();
                Inciar();
            }
            procentaje += 5;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Type t = froma.GetType();
            if (!(t.Equals(typeof(Historial))))
            {
                Cambio_botones();
                froma.Close();
                froma = new Historial(id)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                PanelP.Controls.Add(froma);
                btnHistorial.BackColor = Color.FromArgb(0, 80, 100);
                froma.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Clave forma = new Form_Clave(id);
            froma.Visible = true;
            forma.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Type t = froma.GetType();
            if (!(t.Equals(typeof(Calificaciones))))
            {
                Cambio_botones();
                froma.Close();
                froma = new Calificaciones(id)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                PanelP.Controls.Add(froma);
                btnConsulta.BackColor = Color.FromArgb(0, 80, 100);
                froma.Show();
            }
        }

        private void btnMaestra_Click(object sender, EventArgs e)
        {
            Type t = froma.GetType();
            if (!(t.Equals(typeof(Form_Usuarios))))
            {
                Cambio_botones();
                froma.Close();
                froma = new Form_Usuarios()
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                PanelP.Controls.Add(froma);
                btnMaestra.BackColor = Color.FromArgb(0, 80, 100);
                froma.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringName"].ToString();
                SqlConnection cnn = new SqlConnection(ConnectionString);


                SqlCommand cmd = new SqlCommand("backupdb", cnn);
                cmd.CommandType = CommandType.StoredProcedure;




                cnn.Open();


                cmd.ExecuteNonQuery();


                MessageBox.Show("El backup fue realizado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
