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

            ListaSucursalSecon();
            ListaSucursalPrima();
            Autos();
        }
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
      

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

        private void Autos()
        {
            cbxAutos.DataSource = LitaAutos();
            cbxAutos.DisplayMember = "Nombre";
            cbxAutos.ValueMember = "IdAutomovil";
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
    }
}
