using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIOS
{
    public class CN_Consultas_consul
    {
        public List<Modelo> ListarConsultas()
        {
            return new CD_Consulta_consul().ObtenerREgistros();
        }
        public List<Modelo> ObtenerREgistros_porSemana(int NumeroSemana)
        {
            return new CD_Consulta_consul().ObtenerREgistros_porSemana(NumeroSemana);
        }
        public List<Modelo>  ObtenerREgistros_porMaterias(int ID_materias)
        {
            return new CD_Consulta_consul().ObtenerREgistros_porMaterias(ID_materias);
        }
        public List<Modelo> ObtenerREgistros_porCarnet(string Carnet)
        {
            return new CD_Consulta_consul().ObtenerREgistros_porCarnet(Carnet);
        }
        public void AgregarConsultas(int ID_materias, int Numero_semana, int Cantidad_Estudiante,
            string Tipo_consulta, string Tema_consulta, DateTime Fecha, string Hora, string Numero_Carnet, string Firma, string Observaciones, int VoBo_Jefe)
        {
            new CD_Consulta_consul().AgregarConsulta(ID_materias, Numero_semana, Cantidad_Estudiante,
            Tipo_consulta, Tema_consulta, Fecha, Hora,  Numero_Carnet,Firma, Observaciones,  VoBo_Jefe);
        }
        //----------------------------------------------------------------------------
        public void EliminarConsulta(int ID_consulta)
        {
            //forma tradicional de crear un objeto y llamar un metodo
           /* CD_Consulta_consul consul = new CD_Consulta_consul();
            consul.Eliminar_Consulta(ID_consulta);
           */

            //forma alternativa o forma pro
            new CD_Consulta_consul().Eliminar_Consulta(ID_consulta);
        }

        public void EditarConsulta(int ID_Consult)
        {
            new CD_Consulta_consul().Editar_Consult(ID_Consult);
        }

    }
}
