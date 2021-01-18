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
namespace Concesionaria
{
    public partial class Traspasos : Form
    {
        public Traspasos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Traspasos_Load(object sender, EventArgs e)
        {
            MostrarTraspasos();
            ListaSucursalSecon();
            ListaSucursalPrima();
           
           
        }
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        Consultas2 Metodos = new Consultas2();
        public int IdTraspaso;

        public DataTable LitaSucursalSecu()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarSucursalSecundaria";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();

            return Tabla;
        }


        public DataTable LitaSucursalPrimaria()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarSucursalPrincipal";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListaColor(string Modelo)
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarColor";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable LitaAutos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarAutos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


        public int UltimoId()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarUltimoID";
            Comando.CommandType = CommandType.StoredProcedure;
           
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            return Convert.ToInt32(Comando.ExecuteScalar());
            Conexion.CerrarConexion();


          


        }

        private void MostrarTraspasos() 
        {
            Consultas2 Metodo = new Consultas2();
           dgvFactura.DataSource= Metodo.MostrarFacturaTraspaso();
        }

        private void MostrarDetalle (int id)
        {
            Consultas2 Metodo = new Consultas2();
            dgvDetalle.DataSource = Metodo.MostrarDetalleTraspaso(id);
        }





        private void ListaSucursalSecon ()
        {
            cbxDestino.DataSource = LitaSucursalSecu();
            cbxDestino.DisplayMember = "Nombre";
            cbxDestino.ValueMember = "IdSucursal_Secundaria";
        }

        private void ListaSucursalPrima()
        {
            cbxOrigen.DataSource = LitaSucursalPrimaria();
            cbxOrigen.DisplayMember = "Nombre";
            cbxOrigen.ValueMember = "IdSucursal";
        }

     

        

        private void txtDocIdentidad_Enter(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //ListaColores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private SqlConnection Conexionn = new SqlConnection("Server=DESKTOP-NDLJN6T;DataBase= concesionario;Integrated Security=true");


        private void button1_Click(object sender, EventArgs e)
        {
            Metodos.InsertarTraspaso(dateFecha.Text,Convert.ToInt32(cbxOrigen.SelectedValue),Convert.ToInt32(cbxDestino.SelectedValue), txtTipo.Text);
            Conexionn.Open();
            string query = "select ISNULL(MAX(IdTraspasoSAS), 0) AS LASTID from TraspasoSAS";
            SqlCommand command = new SqlCommand(query, Conexionn);

         
            IdTraspaso =  Convert.ToInt32(command.ExecuteScalar()) ;
            Conexionn.Close();

          

            AutosTraspaso Ventana = new AutosTraspaso(IdTraspaso);
            
            Ventana.Show();
        }

        private void btnConsultarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvFactura.SelectedRows.Count > 0)
            {






                MostrarDetalle(Convert.ToInt32(dgvFactura.CurrentRow.Cells["IdTraspasoSaS"].Value.ToString()));

              

            }
            else
                MessageBox.Show("seleccione una fila por favor de Traspasos");
        }
    }
}
