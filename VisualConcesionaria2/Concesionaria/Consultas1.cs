using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Concesionaria
{
    class Consultas1
    {
        int ICConta = 1;

        // CREACION DE OBJETO PARA LLAMAR CONSULTA
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();


        //Procedimientos

        //-------------------------

        //Insertar
        // I N S E R T A R 
        
        public void InsertarCliente( string Nombre, string Apellidos,string Password ,string Telefono,string Correo, int Edad,string Direccion,string Sexo, string FechaNacimiento, string RFC, string Referencia1, string NumR1, string Referencia2, string NumR2, string Referencia3, string NumR3)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarCliente";
            comandoInsertar.CommandType = CommandType.StoredProcedure;   
            comandoInsertar.Parameters.AddWithValue("@Nombre", Nombre);
            comandoInsertar.Parameters.AddWithValue("@Apellidos", Apellidos);
            comandoInsertar.Parameters.AddWithValue("@PasswordCliente",Password);
            comandoInsertar.Parameters.AddWithValue("@Telefono", Telefono);
            comandoInsertar.Parameters.AddWithValue("@Correo", Correo);
            comandoInsertar.Parameters.AddWithValue("@Edad", Edad);
            comandoInsertar.Parameters.AddWithValue("@Direccion", Direccion);
            comandoInsertar.Parameters.AddWithValue("@Sexo", Sexo);
            comandoInsertar.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comandoInsertar.Parameters.AddWithValue("@RFC", RFC);
            comandoInsertar.Parameters.AddWithValue("@ReferenciaUno", Referencia1);
            comandoInsertar.Parameters.AddWithValue("@NumRefUno", NumR1);
            comandoInsertar.Parameters.AddWithValue("@ReferenciaDos", Referencia2);
            comandoInsertar.Parameters.AddWithValue("@NumRefDos", NumR2);
            comandoInsertar.Parameters.AddWithValue("@ReferenciaTres", Referencia3);
            comandoInsertar.Parameters.AddWithValue("@NumRefTres", NumR3);
            comandoInsertar.Parameters.AddWithValue("@TipoUsuario", 2);
            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;

         
        }
        
        public void InsertarEmpleado(string Nombre, string Apellidos,string Correo, string Password, string FechaNacimiento,string FechaIngreso, string Telefono)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarEmpleado";
            comandoInsertar.CommandType = CommandType.StoredProcedure;
            comandoInsertar.Parameters.AddWithValue("@Nombre", Nombre);
            comandoInsertar.Parameters.AddWithValue("@Apellidos", Apellidos);
            comandoInsertar.Parameters.AddWithValue("@Correo", Correo);
            comandoInsertar.Parameters.AddWithValue("@PasswordEmpleado", Password);
            comandoInsertar.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comandoInsertar.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            comandoInsertar.Parameters.AddWithValue("@Telefono", Telefono);
            comandoInsertar.Parameters.AddWithValue("@Sucursal", 1);
            comandoInsertar.Parameters.AddWithValue("@TipoUsuario", 1);
            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;


        }

        public void InsertarAutomovil(string Marca,string Modelo, string Color, string Año, string Serie, string FechaIngreso, string PrecioCompra, string PrecioVenta)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarAutomovil";
            comandoInsertar.CommandType = CommandType.StoredProcedure;
            comandoInsertar.Parameters.AddWithValue("@Marca", Marca);
            comandoInsertar.Parameters.AddWithValue("@Modelo", @Modelo);
            comandoInsertar.Parameters.AddWithValue("@Color", Color);
            comandoInsertar.Parameters.AddWithValue("@Año", Año);
            comandoInsertar.Parameters.AddWithValue("@Serie", Serie);
            comandoInsertar.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            comandoInsertar.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
            comandoInsertar.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
            comandoInsertar.Parameters.AddWithValue("@Sucursal", 1);
            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;




        }

        //Mostrar


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

        public DataTable MostrarEmpleados()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarAutos()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAutos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


      


        //Eliminar
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


        public void EliminarEmpleado(int IdEmpleados)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdEmpleados", IdEmpleados);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void EliminarAutomovil(int IdAutomovil)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAutomovil";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAutomovil", IdAutomovil);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        //Editar

        public void EditarCliente(string Nombre, string Apellidos, string Password, string Telefono, string Correo, int Edad, string Direccion, string Sexo, string FechaNacimiento, string RFC, string Referencia1, string NumR1, string Referencia2, string NumR2, string Referencia3, string NumR3)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            comando.Parameters.AddWithValue("@PasswordCliente", Password);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Edad", Edad);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Sexo", Sexo);
            comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@RFC", RFC);
            comando.Parameters.AddWithValue("@ReferenciaUno", Referencia1);
            comando.Parameters.AddWithValue("@NumRefUno", NumR1);
            comando.Parameters.AddWithValue("@ReferenciaDos", Referencia2);
            comando.Parameters.AddWithValue("@NumRefDos", NumR2);
            comando.Parameters.AddWithValue("@ReferenciaTres", Referencia3);
            comando.Parameters.AddWithValue("@NumRefTres", NumR3);
            comando.Parameters.AddWithValue("@TipoUsuario", 2);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        public void EditarEmpleado(string Nombre, string Apellidos, string Correo, string Password, string FechaNacimiento, string FechaIngreso, string Telefono)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarEmplead";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellidos", Apellidos);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@PasswordEmpleado", Password);
            comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Sucursal", 1);
            comando.Parameters.AddWithValue("@TipoUsuario", 1);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        public void EditarAutomovil(string Marca, string Modelo, string Color, string Año, string Serie, string FechaIngreso, string PrecioCompra, string PrecioVenta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarAutomovil";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Marca", Marca);
            comando.Parameters.AddWithValue("@Modelo", Modelo);
            comando.Parameters.AddWithValue("@Color", Color);
            comando.Parameters.AddWithValue("@Año", Año);
            comando.Parameters.AddWithValue("@Serie", Serie);
            comando.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            comando.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
            comando.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
            comando.Parameters.AddWithValue("@Sucursal", 1);



            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }


        

    }
}
