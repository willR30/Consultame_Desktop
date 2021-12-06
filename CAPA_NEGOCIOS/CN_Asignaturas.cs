using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;

namespace CAPA_NEGOCIOS
{
    public class CN_Asignaturas
    {
        CD_Consultas_asignatura asignaturas_CD = new CD_Consultas_asignatura();

        public DataTable ListarAsignaturas()
        {
            return asignaturas_CD.ListarAsignaturas();

        }
        public void AgregarAsignaturas(string Nombre)
        {
            asignaturas_CD.AgregarAsignatura(Nombre);
        }

    }
}
