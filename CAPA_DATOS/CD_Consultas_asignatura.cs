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
    public class CD_Consultas_asignatura
    { //esta clase guardará lasquery de las consultas
        //objeto para establecer la conexion
        private CD_Conexion Conexion = new CD_Conexion();
        SqlDataReader leer;//leemos las consultas
        DataTable tabla = new DataTable();//cargadmos los dato de la db
        //objeto para los comandos de sql
        SqlCommand comando = new SqlCommand();
        //instanciamos la llista para guardar los


        //-------------------metodos de consultas
        public DataTable ListarAsignaturas()
        {
            comando.Connection = Conexion.AbrirConexion();//nos estamos conectado al servidor mediante la clase CD_Conexion
            string consulta = "SELECT * FROM Materias";//indicamos cual es nuestra consulta
            comando.CommandText = consulta;//le pasamos la consulta al servidor
            leer = comando.ExecuteReader();//leemo los datos encontrados
            tabla.Load(leer);//cargamos los datos para mostrarlos mas adelante

            Conexion.CerrarConexion();//cerramos la conexion al servidor
            return tabla;//retornamos los datos leidos para mostrase en la interfaz
        }
        public void AgregarAsignatura(string Nombre)
        {

            //validar exception

            comando.Connection = Conexion.AbrirConexion();//nos conectamos al servidor
            string consulta = "INSERT INTO  materias (Nombre_Materia) Values ('"+Nombre+"')";
            comando.CommandText = consulta;//pasamos la consulta
                                           //ejecutamos la consulta
            comando.ExecuteNonQuery();
            //cerramos la conexion
            Conexion.CerrarConexion();

        }
    }
}
