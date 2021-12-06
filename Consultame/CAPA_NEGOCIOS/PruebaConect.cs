using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using System.Data.SqlClient;

namespace CAPA_NEGOCIOS
{
    public class PruebaConect
    {

        public  void PruebaConeccion()
        {
            SqlConnection conectar= new SqlConnection();
            conectar = new CD_Conexion().AbrirConexion();
          
            
        }






    }
}
