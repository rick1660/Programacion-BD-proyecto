using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoBD;


namespace ProyectoBD
{


    public class Consultas1
    {

        // CREACION DE OBJETO PARA LLAMAR CONSULTA
        private SQLConexion conexion = new SQLConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
       



        // PROCEDIMIENTOS


        //  - - - - - -- - - - - - - - - - - - - - - - - - - - - - - - 


        // M O S T R A R 
        public DataTable MostrarClientes()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarAutomovil()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAutomovil";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarDiagnostico()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDiagnostico";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarEmpleado()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public DataTable MostrarRefaccion()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarRefaccion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarServicios()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarServicios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarHistorial()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarHistorial";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        //  - - - - - - - - - - - - - -- - - - - - - - - - - -- - - - - - - - - - - - -- - - 


        // I N S E R T A R 
        public void InsertarAutomovil(int IdVehiculo, int NumSerie, string Marca, string Modelo, int Año, string Color, DateTime Fecha_R, int IdCliente)
        {
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAutomovil";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
            comando.Parameters.AddWithValue("@NumSerie", NumSerie);
            comando.Parameters.AddWithValue("@Marca", Marca);
            comando.Parameters.AddWithValue("@Modelo", Modelo);
            comando.Parameters.AddWithValue("@Color", Color);
            comando.Parameters.AddWithValue("@Año", Año);
            comando.Parameters.AddWithValue("@Fecha_R", Fecha_R);
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }



        public void InsertarCliente(int IdCliente, string Nombre, string Apellidos, string Direccion, string Telefono, string Email)
        {
            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarCliente";
            comandoInsertar.CommandType = CommandType.StoredProcedure;

            comandoInsertar.Parameters.AddWithValue("@IdCliente", IdCliente);
            comandoInsertar.Parameters.AddWithValue("@Nombre", Nombre);
            comandoInsertar.Parameters.AddWithValue("@Apellidos", Apellidos);
            comandoInsertar.Parameters.AddWithValue("@Direccion", Direccion);
            comandoInsertar.Parameters.AddWithValue("@Telefono", Telefono);
            comandoInsertar.Parameters.AddWithValue("@Email", Email);


            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;
        }


        public void InsertarDiagnostico(int IdDiagnostico, string Falla, string Causa, int IdVehiculo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDiagnostico";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdDiagnostico", IdDiagnostico);
            comando.Parameters.AddWithValue("@Falla", Falla);
            comando.Parameters.AddWithValue("@Causa", Causa);
            comando.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }



        public void InsertarEmpleado(int IdEmpleado, string Nombre, string Telefono, int IdDepartamento, int IdVehiculo)
        {
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);
            comando.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void InsertarRefaccion(int IdRefaccion, string Nombre, Double Costo, DateTime FechaE, DateTime FechaS, int IdDepartamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarRefaccion";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdRefaccion", IdRefaccion);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Costo", Costo);
            comando.Parameters.AddWithValue("@FechaE", FechaE);
            comando.Parameters.AddWithValue("@FechaS", FechaS);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        public void InsertarServicio(int IdServicio, Double Costo, DateTime Fecha, string Nombre, int Promocion, DateTime InicioG, DateTime FinalG, int IdDiagnostico, int IdDepartamento, int Veces)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarServicio";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdServicio", IdServicio);
            comando.Parameters.AddWithValue("@Costo", Costo);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Promocion", Promocion);
            comando.Parameters.AddWithValue("@InicioG", InicioG);
            comando.Parameters.AddWithValue("@FinalG", FinalG);
            comando.Parameters.AddWithValue("@IdDiagnostico", IdDiagnostico);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);
            comando.Parameters.AddWithValue("@Veces", Veces);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }



        // E L I M I N A C I O N
        public void EliminarCliente(int IdCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdCliente", IdCliente);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void EliminarEmpleado(int IdEmpleado)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void EliminarVehiculo(int IdVehiculo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAutomovil";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        public void EliminarRefaccion(int IdRefaccion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarRefaccion";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdRefaccion", IdRefaccion);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        // E D I T A R

        public void EditarEmpleado(int IdEmpleado, string Nombre, string Telefono, int IdDepartamento, int IdVehiculo)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);
            comando.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void EditarRefaccion(int IdRefaccion, string Nombre, Double Costo, DateTime FechaE, DateTime FechaS, int IdDepartamento)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarRefaccion";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdRefaccion", IdRefaccion);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Costo", Costo);
            comando.Parameters.AddWithValue("@FEntrada", FechaE);
            comando.Parameters.AddWithValue("@FSalida", FechaS);
            comando.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();


        }


        public void EditarAutomovil(int IdVehiculo, int NumSerie, string Marca, string Modelo, string Color, int Año,  DateTime Fecha_R, int IdCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarAutomovil";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
            comando.Parameters.AddWithValue("@NumSerie", NumSerie);
            comando.Parameters.AddWithValue("@Marca", Marca);
            comando.Parameters.AddWithValue("@Modelo", Modelo);
            comando.Parameters.AddWithValue("@Color", Color);
            comando.Parameters.AddWithValue("@Año", Año);
            comando.Parameters.AddWithValue("@Feche_Registro", Fecha_R);
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void EditarCliente(int IdCliente, string Nombre, string Apellidos, string Direccion, string Telefono, string Email)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Email);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }




    }
}
