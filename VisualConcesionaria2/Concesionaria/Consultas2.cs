using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Concesionaria
{
    class Consultas2
    {
        // CREACION DE OBJETO PARA LLAMAR PROCEDIMIENTO Y METODO
        public Consultas1 conexion = new Consultas1();

        //-----------------------Insertar----------------------------------

        public void InsertarCliente(string Nombre, string Apellidos,string Password, string Telefono, string Correo, string Edad,string Direccion, string Sexo, string FechaNacimiento, string RFC, string Referencia1, string NumR1, string Referencia2, string NumR2, string Referencia3, string NumR3)
        {

            conexion.InsertarCliente( Nombre, Apellidos,Password , Telefono, Correo, Convert.ToInt32(Edad), Direccion, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3);
        }

        public void InsertarEmpleado(string Nombre, string Apellidos, string Correo, string Password, string FechaNacimiento, string FechaIngreso, string Telefono)
        {

            conexion.InsertarEmpleado(Nombre, Apellidos, Correo, Password, FechaNacimiento,FechaIngreso ,Telefono);
        }


        public void InsertarAuto(string Marca, string Modelo, string Color,string Año, string Serie, string FechaIngreso, string precioCompra,string PrecioVenta)
        {

            conexion.InsertarAutomovil(Marca, Modelo, Color, Año, Serie, FechaIngreso, precioCompra, PrecioVenta); ;
        }

        public void InsertarAccesorios(string Nombre, string Modelo, int Precio,string Cantidad)
        {

            conexion.InsertarAccesorio(Nombre, Modelo, Convert.ToInt32(Precio),Cantidad); ;
        }


        public void InsertarRuta(string Ruta)
        {

            conexion.InsertarRuta(Ruta); ;
        }

        public void InsertarTraspaso(string Fecha, int SucursalEntrega, int SucursalRecibe, string TipoTraspaso) 
        {
            conexion.InsertarTraspaso(Fecha, SucursalEntrega, SucursalRecibe, TipoTraspaso);
        }


        public void InsertarDetalleTraspaso(int IdTraspasoSas, int automovil) 
        {
            conexion.InsertarDetalleTraspaso(IdTraspasoSas, automovil);
        }

        //------------------------Mostrar-------------------------------
        public DataTable MostrarCliente()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarClientes();
            return tabla;
        }


        public DataTable MostrarEmpleados()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarEmpleados();
            return tabla;
        }


        public DataTable MostrarAutos()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarAutos();
            return tabla;
        }

        public DataTable MostrarAccesorios()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarAccesorios();
            return tabla;
        }

        public DataTable MostrarAdmin()
        {

            DataTable tabla = new DataTable();
            tabla = conexion.MostrarAdmin();
            return tabla;
        }


        public DataTable MostrarSucursalSecundaria() 
        {
            DataTable tabla = new DataTable();
            tabla = conexion.MostrarSucursalSecundaria();
            return tabla;

        }


        public DataTable MostrarDetalleTraspaso(int idTraspaso)
        {
            DataTable tabla = new DataTable();
            tabla = conexion.MostrarDetalleTraspaso(idTraspaso);
            return tabla;

        }


        public DataTable MostrarFacturaTraspaso()
        {
            DataTable tabla = new DataTable();
            tabla = conexion.MostrarFacturaTraspaso();
            return tabla;

        }


        //------------------------Eliminar---------------------------

        public void EliminarCliente(string IdCliente)
        {

            conexion.EliminarCliente(Convert.ToInt32(IdCliente));
        }

        public void EliminarEmpleado(string IdEmpleados)
        {

            conexion.EliminarEmpleado(Convert.ToInt32(IdEmpleados));
        }

        public void EliminarAutomovil(string IdAutomovil)
        {

            conexion.EliminarAutomovil(Convert.ToInt32(IdAutomovil));
        }

        public void EliminarAccesorio(string IdAutopartes)
        {

            conexion.EliminarAccesorio(Convert.ToInt32(IdAutopartes));
        }



        public void EliminarRuta()
        {

            conexion.EliminarRuta();
        }


        //-------------------Editar-------------------------------------
        public void EditarCliente(string Nombre, string Apellidos, string Password, string Telefono, string Correo, string Edad, string Direccion, string Sexo, string FechaNacimiento, string RFC, string Referencia1, string NumR1, string Referencia2, string NumR2, string Referencia3, string NumR3)
        {

            conexion.EditarCliente(Nombre, Apellidos, Password, Telefono, Correo, Convert.ToInt32(Edad), Direccion, Sexo, FechaNacimiento, RFC, Referencia1, NumR1, Referencia2, NumR2, Referencia3, NumR3);
        }

        public void EditarEmpleado(string Nombre, string Apellidos, string Correo, string Password, string FechaNacimiento, string FechaIngreso, string Telefono)
        {

            conexion.EditarEmpleado(Nombre, Apellidos, Correo, Password, FechaNacimiento, FechaIngreso, Telefono);
        }

        public void EditarAutomovil(string Marca, string Modelo, string Color, string Año, string Serie, string FechaIngreso, string PrecioCompra, string PrecioVenta )
        {

            conexion.EditarAutomovil(Marca, Modelo, Color, Año, Serie, FechaIngreso, PrecioCompra, PrecioVenta);
        }

        public void EditarAccesorio(string Nombre, string Modelo, int Precio, string Cantidad)
        {

            conexion.EditarAccesorio(Nombre, Modelo, Convert.ToInt32(Precio), Cantidad);
        }



        public void EditarAdmin(int IdAdministrador,string Nombre, string Dirreccion, string Telefono, string Correo, string Contraseña, string FechaIngreso)
        {

            conexion.EditarAdmin(Convert.ToInt32(IdAdministrador),Nombre, Dirreccion, Telefono, Correo, Contraseña, FechaIngreso);
        }
    }
}
