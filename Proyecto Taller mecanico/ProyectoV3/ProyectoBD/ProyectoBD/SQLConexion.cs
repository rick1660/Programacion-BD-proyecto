﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoBD;


namespace ProyectoBD
{
    class SQLConexion
    {
            private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-NDLJN6T;DataBase= ProyectoBD_2;Integrated Security=true");

            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }

            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
        
    }
}
