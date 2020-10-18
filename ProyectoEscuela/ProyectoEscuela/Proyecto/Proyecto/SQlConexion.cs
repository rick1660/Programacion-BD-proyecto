using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;
using System.Threading;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Proyecto

{
    public class SQlConexion
    { 
        //Instanciar los objetos necesarios para realizar operaciones con la base de datos
        SqlCommand CMD;
        SqlDataReader DR;
        SqlDataAdapter DA;
        DataTable DT;
        SqlConnection Conec = new SqlConnection("Data Source=DESKTOP-KSKH0RR;Initial Catalog=Final;Integrated Security=True");
        //Metodo para abrir la conexion
        public void Abrir()
        {
            Conec.Open();
        }
        //Metodo para Cerrar la Conexion
        public void Cerrar()
        {
            Conec.Close();
        }
        //Metodo Para Hacer una consulta la bd por el NO de Control


        public string Login(int Id,int Pass) {
            Abrir();
            string role = "";
            SqlCommand comando = new SqlCommand(string.Format("Select Rol from T_usuarios where ID_usuario = {0} and Clave = {1}",Id,Pass), Conec);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                role = reader.GetString(0);
            }
            reader.Close();
            Cerrar();
            return role;

        }
        public void Acceso(int Id)
        {

            Abrir();
            SqlCommand UP = new SqlCommand(string.Format("update T_usuarios set Fecha_acceso = Getdate() where ID_usuario = {0}", Id), Conec);
            UP.ExecuteNonQuery();
            Cerrar();

        }
        public void InsertarCal(string Id,string al,string cal,string Estado)
        {

            Abrir();
            try
            {
                SqlCommand UP = new SqlCommand(string.Format("Insert into T_Calificaciones values({0}, {1}, {2}, '{3}', null)", Id, al, cal, Estado), Conec);
                UP.ExecuteNonQuery();
            }
            catch { MessageBox.Show("No Existe Ese Alumno"); }
            Cerrar();
        }

        public void UpdateCal(string Id,string cal, string Estado,string al)
        {

            Abrir();
            SqlCommand UP = new SqlCommand(string.Format("update T_Calificaciones set ID_maestro={0},Calificacion={1},B_Final= '{2}'where ID_alumno={3}", Id, cal, Estado,al), Conec);
            UP.ExecuteNonQuery();
            Cerrar();
        }
        public void BajaCal(string Id, string al)
        {

            Abrir();
            SqlCommand UP = new SqlCommand(string.Format("Delete T_Calificaciones where ID_maestro = {0} and ID_alumno={1}", Id, al), Conec);
            UP.ExecuteNonQuery();
            Cerrar();
        }
        public DataTable Tabla(string Tab)
        {
            DataTable T = new DataTable();
            SqlDataAdapter C = new SqlDataAdapter(string.Format("select * from {0}",Tab), Conec);
            C.Fill(T);
            return T;
        }
        public DataTable CalMaestro(int Maestro)
        {
            DataTable T = new DataTable();
            SqlDataAdapter C = new SqlDataAdapter(string.Format("select * from T_Calificaciones where ID_maestro = {0}", Maestro), Conec);
            C.Fill(T);
            return T;
        }
        public DataTable Maestros()
        {
            DataTable T = new DataTable();
            SqlDataAdapter C = new SqlDataAdapter(string.Format("select ID_usuario, Nombre, Apellido, Clave, Sexo, Rol, Fecha_registro, B_activo from T_usuarios"), Conec);
            C.Fill(T);
            return T;
        }

        public bool Insertar(int Idusuario, int Clave, string Sexo, string activo, string nombre, string apellido, string rol)
        {
            Abrir();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO T_usuarios(ID_usuario, Nombre, Apellido, Clave, Sexo, Rol, Fecha_Registro, B_activo) VALUES({0}, '{1}', '{2}', {3}, '{4}', '{5}', getdate(), '{6}')", Idusuario, nombre, apellido, Clave, Sexo, rol, activo), Conec);
            int filasafectadas = cmd.ExecuteNonQuery();
            Cerrar();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public bool ModificarClave(int Id, int ClaveAntiguna, int ClaveNueva)
        {
            bool v = false;
            String p = Login(Id, ClaveAntiguna);
            Abrir();
            if (p != "") {
                try {
                    SqlCommand comando = new SqlCommand(string.Format("update T_usuarios set Clave = {0} where ID_usuario = {1}", ClaveNueva, Id), Conec);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se Ingreso correctamente la clave");
                    v = true;

                } catch (Exception e) {
                    MessageBox.Show(e.Message);
                    v = false;
                }
                
            }
            
            Cerrar();
            return v;
        }

        public bool Existe(int Id)
        {
            bool v = false;
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("Select Nombre from T_usuarios where ID_usuario = {0}", Id), Conec);
            SqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                if (reader.GetString(0)!="")
                v = true;
            }
            Cerrar();
            return v;
        }
        public bool ExisteCal(int IdA)
        {
            bool v = false;
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("Select ID_maestro from T_Calificaciones where ID_alumno = {0}",IdA), Conec);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetInt32(0).ToString() != "")
                    v = true;
            }
            Cerrar();
            return v;
        }
        public bool Estado(int Id)
        {
            bool b = false;
            string estado="";
            Abrir();

            SqlCommand comando = new SqlCommand(string.Format("Select B_activo from T_usuarios where ID_usuario = {0}", Id), Conec);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
               estado = reader.GetString(0);
            }
            Cerrar();
            if (estado == "T")
                b = true;
            else if (estado == "F")
                b = false;

            return b;
        }
        public bool EstadoCal(int Id)
        {
            bool b = false;
            string estado = "";
            Abrir();

            SqlCommand comando = new SqlCommand(string.Format("Select B_Final from T_Calificaciones where ID_alumno = {0}", Id), Conec);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                estado = reader.GetString(0);
            }
            Cerrar();
            if (estado == "T")
                b = true;
            else if (estado == "F")
                b = false;

            return b;
        }
        public bool FechaF(int M,string A)
        {
            bool b = false;
            string estado = "";
            Abrir();

            SqlCommand comando = new SqlCommand(string.Format("Select B_Final from T_Calificaciones where Fecha_Final < getdate() and ID_maestro = {0} and ID_alumno = {1}", M,A), Conec);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                estado = reader.GetString(0);
            }
            Cerrar();
            if (estado != "")
                b = true;
            return b;
        }

        public void UpdateFecha(int M, string A)
        {
            bool b = false;
            string estado = "";
            Abrir();

            SqlCommand comando = new SqlCommand(string.Format("update T_Calificaciones set Fecha_Final = getdate() where ID_maestro = {0} and ID_alumno = {1}", M, A), Conec);
            comando.ExecuteNonQuery();
        }

        public DataTable Kardex(int Usuario)
        {
            Abrir();           

            SqlDataAdapter Comando = new SqlDataAdapter("Select Nombre, Calificacion from T_calificaciones join T_usuarios on T_calificaciones.ID_maestro = T_usuarios.ID_usuario where T_calificaciones.ID_alumno = " + Usuario.ToString(), Conec);

            DataTable Tabla = new DataTable();
            Comando.Fill(Tabla);

            Cerrar();
            return Tabla;
        }
        ///.......................................................................................
        ///



        public void ModificarAlumno(int No,int Id,string Nombre,string AP,string AM,int Sem, int Car)
        {
            Abrir();
            SqlCommand comando = new SqlCommand("ModificarAlumno", Conec);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Par = new SqlParameter("CR", SqlDbType.Int);
            Par.Direction = ParameterDirection.Output;

            comando.Parameters.Add("@No", SqlDbType.Int).Value = No;
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
            comando.Parameters.Add("@AP", SqlDbType.VarChar).Value = AP;
            comando.Parameters.Add("@AM", SqlDbType.VarChar).Value = AM;
            comando.Parameters.Add("@Sem", SqlDbType.Int).Value = Sem;
            comando.Parameters.Add("@Car", SqlDbType.Int).Value = Car;


            comando.ExecuteNonQuery();
            Cerrar();
        }
        public void NuevoAl( int Id, string Nombre, string AP, string AM, int Sem, int Car)
        {
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("insert into Alumno values({0},'{1}','{2}','{3}','d','{4}',{5},null,{6})",Id,Nombre,AP,AM,DateTime.Now,Sem,Car), Conec);
            comando.ExecuteNonQuery();
            Cerrar();
        }
        public void ModificarCarrera(int Id, string Nombre)
        {
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("update Carreras set Carrera_Nombre = '{1}' where Carrera_Id = {0}", Id, Nombre), Conec);
            comando.ExecuteNonQuery();
            Cerrar();
        }
        public void NuevaCarrera(int Id, string Nombre)
        {
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("insert into Carreras values ({0},'{1}')", Id, Nombre), Conec);
            comando.ExecuteNonQuery();
            Cerrar();
        }
        public void BorrarCarrera(int Id)
        {
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("delete Carreras where Carrera_Id = {0}",Id), Conec);
            comando.ExecuteNonQuery();
            Cerrar();
        }
        public void Eliminar(int No)
        {
            Abrir();
            SqlCommand comando = new SqlCommand("delete Alumno where Alumno_Id="+No.ToString(), Conec);
            comando.ExecuteNonQuery();
            Cerrar();
        }
        public DataTable Registro()
        {
            Abrir();
            string comando = ("Select * from RegistroA ");

            SqlDataAdapter asd = new SqlDataAdapter(comando, Conec);

            DataTable sd = new DataTable();

            asd.Fill(sd);

            Cerrar();
            return sd;
        }
        public DataTable Carreras()
        {
            Abrir();
            string comando = ("Select * from Carreras ");

            SqlDataAdapter asd = new SqlDataAdapter(comando, Conec);

            DataTable sd = new DataTable();

            asd.Fill(sd);

            Cerrar();
            return sd;
        }

        public string BuscarCarrera(int pNo)
        {
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("Select Carrera_Nombre from Carreras where Carrera_Id = {0}", pNo), Conec);

            SqlDataReader reader = comando.ExecuteReader();
            string nombre="";
            while (reader.Read())
            {
                nombre = reader.GetString(0);
            }
            Cerrar();
            return nombre;
        }

        public DataTable Alumnos()
        {
            Abrir();
            string comando = ("Select * from Alumno ");

            SqlDataAdapter asd = new SqlDataAdapter(comando, Conec);

            DataTable sd = new DataTable();

            asd.Fill(sd);

            Cerrar();
            return sd;
        }

        //Metodo para obtener el historial de Pedidos de un alumno
        public DataTable Filtro(int pNo)
        {
            Abrir();
            string comando = ("Select * from RegistroA where RegistroA_Alumno = " + pNo.ToString());

            SqlDataAdapter asd = new SqlDataAdapter(comando, Conec);

            DataTable sd = new DataTable();

            asd.Fill(sd);

            Cerrar();
            return sd;
        }

        //Metodo Para Cargar El Status de una Computadora
        public char StatusPc(int No)
        {
            char Status=' ';
            Abrir();
            SqlCommand comando = new SqlCommand(string.Format("Select Ubicacion_Estatus from Ubicaciones where Ubicacion_Computadora_Id = {0}", No), Conec);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Status = Convert.ToChar(reader.GetString(0));
            }
            Cerrar();

            return Status;
        }

        public void Pedir(int No,int Com,string Mot)
        {
            Abrir();
            SqlCommand comando = new SqlCommand("PedirPc",Conec);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Par = new SqlParameter("CR", SqlDbType.Int);
            Par.Direction = ParameterDirection.Output;

            comando.Parameters.Add("@No", SqlDbType.Int).Value=No;
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = Com;
            comando.Parameters.Add("@Datos", SqlDbType.VarChar).Value = Mot ;

            comando.ExecuteNonQuery();
            Cerrar();
        }

        public void EntregarPc(int No,int Pc)
        {
            Abrir();
            SqlCommand comando = new SqlCommand("EntregarPc", Conec);
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter Par = new SqlParameter("CR", SqlDbType.Int);
            Par.Direction = ParameterDirection.Output;

            comando.Parameters.Add("@No", SqlDbType.Int).Value = No;
            comando.Parameters.Add("@Id", SqlDbType.Int).Value = Pc;
            comando.ExecuteNonQuery();
            Cerrar();
        }



    }
}