using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIOS;//importas la capa

namespace CAPA_PRESENTACION
{
    public partial class Editar_Eliiminar : Form
    {
        private int IDConsulta, Num_Semana,Cant_Est;
        private string TipoConsult,TemaConsult;
        private DateTime FechaConsult;
        public Editar_Eliiminar(int ID_consulta,int Numero_Semana,int Cantidad_Estudiante,string Tipo_Consult, string Tema_Consult,DateTime Fecha_consulta)
        {
            //este es el metodo contructor
            IDConsulta = ID_consulta;//hacemos local el varo que espera
            Num_Semana = Numero_Semana;
            Cant_Est = Cantidad_Estudiante;
            TipoConsult = Tipo_Consult;
            TemaConsult = Tema_Consult;
            FechaConsult = Fecha_consulta;
            InitializeComponent();
            CargarCampos();
        }
        private void CargarCampos()
        {
            this.txt_NumSemanas.Text = Convert.ToString(Num_Semana);
            this.txt_CanEst.Text = Convert.ToString(Cant_Est);
            this.cbTipoConsult.SelectedItem = Convert.ToString(this.TipoConsult);
            this.txt_TemaConsult.Text = TemaConsult;
            this.dt_Fecha.Value = this.FechaConsult;
            
        } 
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            new CN_Consultas_consul().EliminarConsulta(this.IDConsulta);

            this.Hide();//ocultar el que  formulario
        }
    }
}
