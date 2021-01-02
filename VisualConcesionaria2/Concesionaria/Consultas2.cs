using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
