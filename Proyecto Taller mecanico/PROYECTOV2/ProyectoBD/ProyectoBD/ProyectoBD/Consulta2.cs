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
    public class Consulta2
    {
        // CREACION DE OBJETO PARA LLAMAR PROCEDIMIENTO Y METODO
        public Consultas1 conexion = new Consultas1();


        public DataTable MostrarAutomovil()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarAutomovil();
            return tabla;
        }

        public DataTable MostrarCliente()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarClientes();
            return tabla;
        }

        public DataTable MostrarDiagnostico()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarDiagnostico();
            return tabla;
        }

        public DataTable MostrarEmpleado()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarEmpleado();
            return tabla;
        }

        public DataTable MostrarRefaccion()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarRefaccion();
            return tabla;
        }

        public DataTable MostrarServicios()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarServicios();
            return tabla;
        }

        public DataTable MostrarHistorial()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarHistorial();
            return tabla;
        }



        //  I N S E R T A R
        public void InsertarAutomovil(string IdVehiculo, string NumSerie, string Marca, string Modelo, string Año, string Color, string Fecha_R, string IdCliente)
        {

            conexion.InsertarAutomovil(Convert.ToInt32(IdVehiculo), Convert.ToInt32(NumSerie), Marca, Modelo, Convert.ToInt32(Año), Color, Convert.ToDateTime(Fecha_R), Convert.ToInt32(IdCliente));
        }

        public void InsertarCliente(string IdCliente, string Nombre, string Apellidos, string Direccion, string Telefono, string Email)
        {

            conexion.InsertarCliente(Convert.ToInt32(IdCliente), Nombre, Apellidos, Direccion, Telefono, Email);
        }

        public void InsertarDiagnostico(string IdDiagnostico, string Falla, string Causa, string IdVehiculo)
        {

            conexion.InsertarDiagnostico(Convert.ToInt32(IdDiagnostico), Falla, Causa, Convert.ToInt32(IdVehiculo));
        }

        public void InsertarEmpleado(string Empleado, string Nombre, string Telefono, string IdDepartamento, string IdVehiculo)
        {

            conexion.InsertarEmpleado(Convert.ToInt32(Empleado), Nombre, Telefono, Convert.ToInt32(IdDepartamento), Convert.ToInt32(IdVehiculo));
        }

        public void InsertarRefaccion(string IdRefaccion, string Nombre, string Costo, string FechaE, string FechaS, string IdDepartamento)
        {

            conexion.InsertarRefaccion(Convert.ToInt32(IdRefaccion), Nombre, Convert.ToDouble(Costo), Convert.ToDateTime(FechaE), Convert.ToDateTime(FechaS), Convert.ToInt32(IdDepartamento));
        }


        public void InsertarServicio(string IdServicio, string Costo, string Fecha, string Nombre, string Promocion, string InicioG, string FinalG, string IdDiagnostico, string IdDepartamento, string Veces)
        {

            conexion.InsertarServicio(Convert.ToInt32(IdServicio), Convert.ToDouble(Costo), Convert.ToDateTime(Fecha), Nombre, Convert.ToInt32(Promocion), Convert.ToDateTime(InicioG), Convert.ToDateTime(FinalG), Convert.ToInt32(IdDiagnostico), Convert.ToInt32(IdDepartamento), Convert.ToInt32(Veces));
        }


        // E L I M I N A R
        public void EliminarCliente(string IdCliente)
        {

            conexion.EliminarCliente(Convert.ToInt32(IdCliente));
        }

        public void EliminarEmpleado(string IdCliente)
        {

            conexion.EliminarEmpleado(Convert.ToInt32(IdCliente));
        }


        public void EliminarVehiculo(string IdVehiculo)
        {

            conexion.EliminarVehiculo(Convert.ToInt32(IdVehiculo));
        }


        public void EliminarRefaccion(string IdVehiculo)
        {

            conexion.EliminarRefaccion(Convert.ToInt32(IdVehiculo));
        }


        // E D I T A R

        public void EditarEmpleado(string Empleado, string Nombre, string Telefono, string IdDepartamento, string IdVehiculo)
        {

            conexion.EditarEmpleado(Convert.ToInt32(Empleado), Nombre, Telefono, Convert.ToInt32(IdDepartamento), Convert.ToInt32(IdVehiculo));
        }

        public void EditarRefaccion(string IdRefaccion, string Nombre, string Costo, string FechaE, string FechaS, string IdDepartamento)
        {

            conexion.EditarRefaccion(Convert.ToInt32(IdRefaccion), Nombre, Convert.ToDouble(Costo), Convert.ToDateTime(FechaE), Convert.ToDateTime(FechaS), Convert.ToInt32(IdDepartamento));
        }

        public void EditarAutomovil(string IdVehiculo, string NumSerie, string Marca, string Modelo, string Color, string Año,  string Fecha_R, string IdCliente)
        {

            conexion.EditarAutomovil(Convert.ToInt32(IdVehiculo), Convert.ToInt32(NumSerie), Marca, Modelo, Color, Convert.ToInt32(Año), Convert.ToDateTime(Fecha_R), Convert.ToInt32(IdCliente));
        }

        public void EditarCliente(string IdCliente, string Nombre, string Apellidos, string Direccion, string Telefono, string Email)
        {

            conexion.EditarCliente(Convert.ToInt32(IdCliente), Nombre, Apellidos, Direccion, Telefono, Email);
        }



    }
}
