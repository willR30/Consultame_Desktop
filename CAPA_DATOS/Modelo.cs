using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class Modelo
    {
        //esta clase va a contener las propiedades de la tabla a trabajar 
        public int Id { get; set; }
        public int ID_materias { get; set; }
        public int NumeroSemana { get; set; }
        public int Cantidad_estudiantes { get; set; }
        public string Tipo_consulta { get; set; }
        public string Tema_consulta { get; set; }
        public DateTime Fecha_consulta { get; set; }
        public string Hora { get; set; }/**************************************************/
        public string Carnet_estudiantes { get; set; }
        public string Firma_estudiante { get; set; }
        public string Observaciones { get; set; }
        public int ViBo_JefeDepto { get; set; }



    }
}
