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

        public void InsertarAccesorio(string Nombre, string Modelo, int Precio, string Cantidad)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarAccesorio";
            comandoInsertar.CommandType = CommandType.StoredProcedure;
            comandoInsertar.Parameters.AddWithValue("@Nombre", Nombre);
            comandoInsertar.Parameters.AddWithValue("@Modelo", Modelo);
            comandoInsertar.Parameters.AddWithValue("@Precio", Precio);
            comandoInsertar.Parameters.AddWithValue("@Cantidad", Cantidad);
            comandoInsertar.Parameters.AddWithValue("@Sucursal", 1);
           
            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;

    



        }

        public void InsertarRuta(string Ruta)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarRuta";
            comandoInsertar.CommandType = CommandType.StoredProcedure;

            comandoInsertar.Parameters.AddWithValue("@IdRuta", 1);
            comandoInsertar.Parameters.AddWithValue("@Ruta", Ruta);
     
            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;

        }


        public void InsertarTraspaso(string Fehca, int SucursalEntrega, int SucursalRecibe, string TipoTraspaso)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarTraspaso";
            comandoInsertar.CommandType = CommandType.StoredProcedure;

            comandoInsertar.Parameters.AddWithValue("@Fecha", Fehca);
            comandoInsertar.Parameters.AddWithValue("@SucursalEntrega", SucursalEntrega);
            comandoInsertar.Parameters.AddWithValue("@SucursalRecibe", SucursalRecibe);
            comandoInsertar.Parameters.AddWithValue("@TipoTraspaso", TipoTraspaso);
            comandoInsertar.ExecuteNonQuery();
            comandoInsertar.Parameters.Clear();
            comandoInsertar.CommandType = CommandType.Text;

        }


        public void InsertarDetalleTraspaso(int IdTraspasoSas,int automovil)
        {

            SqlCommand comandoInsertar = new SqlCommand();
            comandoInsertar.Connection = conexion.AbrirConexion();
            comandoInsertar.CommandText = "InsertarDetalleTraspaso";
            comandoInsertar.CommandType = CommandType.StoredProcedure;

            comandoInsertar.Parameters.AddWithValue("@IdTraspasoSAS", IdTraspasoSas);
            comandoInsertar.Parameters.AddWithValue("@Automovil", automovil);
          
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

        public DataTable MostrarAccesorios()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAccesorios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarAdmin()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAdmin";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public DataTable MostrarSucursalSecundaria()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarSucursalSecundaria";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarDetalleTraspaso(int idTraspaso)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDetalleTraspaso";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTraspasoSas", idTraspaso);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


        public DataTable MostrarFacturaTraspaso()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarFacturaTraspaso";
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


        public void EliminarAccesorio(int IdAutopartes)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAccesorio";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAutopartes", IdAutopartes);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
        }

        public void EliminarRuta()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarRuta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdRuta", 1);
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

        public void EditarAccesorio(string Nombre, string Modelo, int Precio,string Cantidad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarAccesorios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Modelo", Modelo);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Sucursal", 1);



            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;




        }


        public void EditarAdmin(int IdAdministrador,string Nombre, string Direccion, string Telefono, string Correo, string Contraseña, string FechaIng)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarAdmin";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdAdministrador", IdAdministrador);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Contraseña", Contraseña);
            comando.Parameters.AddWithValue("@FechaIngreso", FechaIng);
            comando.Parameters.AddWithValue("@TipoUsuario", 3);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;




        }


    }
}
