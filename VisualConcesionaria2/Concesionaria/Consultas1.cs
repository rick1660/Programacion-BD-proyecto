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
        // CREACION DE OBJETO PARA LLAMAR CONSULTA
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();


        //Procedimientos

        //-------------------------

        //Insertar
        // I N S E R T A R 

        public void InsertarCliente(string Nombre, string Apellidos,string Password ,int Telefono,string Correo, int Edad,string Sexo, string FechaNacimiento, string RFC, string Referencia1, int NumR1, string Referencia2, int NumR2, string Referencia3, int NumR3)
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
    }
}
