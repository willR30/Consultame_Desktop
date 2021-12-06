using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//clases para uso de consultas sql
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CAPA_DATOS
{
    public class CD_Conexion
    {
        /*agrega el nombre de tu base de datos y el nombre de tu servidor*///DESKTOP-N7B04T0
                                                                           //server   DESKTOP-BKCPHOT     //base de datos
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-N7B04T0;DataBase=Consultame ;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            /*instacia un objeto en tu capa de datos y utiliza este método*/
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            /*No olvides cerrar tu conexion al terminar de trabajar con tus instacias*/
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
