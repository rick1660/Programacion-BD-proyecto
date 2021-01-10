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



        //------------------------Eliminar---------------------------

        public void EliminarCliente(string IdCliente)
        {

            conexion.EliminarCliente(Convert.ToInt32(IdCliente));
        }

        public void EliminarEmpleado(string IdEmpleados)
        {

            conexion.EliminarEmpleado(Convert.ToInt32(IdEmpleados));
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

    }
}
