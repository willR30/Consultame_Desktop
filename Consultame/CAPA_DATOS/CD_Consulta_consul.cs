using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos las librerias que vamos a usar
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace CAPA_DATOS
{
    public class CD_Consulta_consul
    {
        //esta clase guardará lasquery de las consultas
        //objeto para establecer la conexion
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;//leemos las consultas
        DataTable tabla = new DataTable();//cargadmos los dato de la db
        //objeto para los comandos de sql
        SqlCommand comando = new SqlCommand();
        //instanciamos la llista para guardar los objetos de tipo modelo
        List<Modelo> lista = new List<Modelo>();

        public List<Modelo> ObtenerREgistros()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();//conexion al servidor
                comando.CommandText = "SELECT * FROM  Consultas";//consulta
                leer = comando.ExecuteReader();//llemos los datos encontrados
                                               //mientras existan registros por leer cargamos los datos en la cola
                while (leer.Read())
                {
                    //instanicamos un objeto
                    Modelo mod = new Modelo();
                    //construimos la lista rescatando el valor de la propiedad de la tabla
                    mod.Id = (int)leer["ID_Consultas"];
                    mod.ID_materias = (int)leer["IDmaterias"];
                    mod.NumeroSemana = (int)leer["Numero_semana"];
                    mod.Cantidad_estudiantes = (int)leer["Cantidad_estudiante"];
                    mod.Tipo_consulta = (string)leer["Tipo_Consulta"];
                    mod.Tema_consulta = (string)leer["Tema_Consulta"];
                    mod.Fecha_consulta = (DateTime)leer["Fecha"];
                    mod.Hora = (string)leer["Hora"];
                    mod.Carnet_estudiantes = (string)leer["N_carnet"];
                    mod.Firma_estudiante = (string)leer["Firma_Est"];
                    mod.Observaciones = (string)leer["Observaciones"];
                    mod.ViBo_JefeDepto = (int)leer["Vobo_JefeDept"];
                    lista.Add(mod);
                }
               
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return lista;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        public void AgregarConsulta( int ID_materias, int Numero_semana,int Cantidad_Estudiante,
            string Tipo_consulta,string Tema_consulta,DateTime Fecha, string Hora,string Numero_Carnet, string Firma,string Observaciones, int VoBo_Jefe)
        {
            //validar exception
            
                comando.Connection = conexion.AbrirConexion();//nos conectamos al servidor
                string consulta = "insert into Consultas(IDmaterias,Numero_semana,Cantidad_estudiante,Tipo_consulta,Tema_consulta, " +
                        "Fecha,Hora,N_Carnet,Firma_Est,Observaciones,Vobo_JefeDept) Values ("+ID_materias+","+Numero_semana+","+
                        Cantidad_Estudiante+",'"+Tipo_consulta+"','"+Tema_consulta+"','"+  Fecha+"','"+Hora+"','"+Numero_Carnet+"','"+Firma+"','"+Observaciones+"',"+VoBo_Jefe+")";
                comando.CommandText = consulta;//pasamos la consulta
                //ejecutamos la consulta
                comando.ExecuteNonQuery();
                //cerramos la conexion
                conexion.CerrarConexion();
            
           

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Eliminar_Consulta(int ID_conulta)
        {
            comando.Connection = conexion.AbrirConexion();//nos conectamos al servidor
            string consulta = "DELETE FROM Consultas WHERE ID_Consultas= "+ID_conulta;//sta es la consulta
            comando.CommandText = consulta;//pasamos la consulta
                                           //ejecutamos la consulta
            comando.ExecuteNonQuery();
            //cerramos la conexion
            conexion.CerrarConexion();

        }

    }
}
