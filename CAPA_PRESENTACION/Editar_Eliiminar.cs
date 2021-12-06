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
        private string Hora,Numero_Carnet,Firma_Estudiante,Observaciones;
        private int VOBO_jefe;

        public Editar_Eliiminar(int ID_consulta,int Numero_Semana,int Cantidad_Estudiante,string Tipo_Consult, 
            string Tema_Consult,DateTime Fecha_consulta,string Hora_con,string NumeroCarnet,string FirmaEstudiante,string observa,int VOBOJEFE)
        {
            //este es el metodo contructor
            IDConsulta = ID_consulta;//hacemos local el varo que espera
            Num_Semana = Numero_Semana;
            Cant_Est = Cantidad_Estudiante;
            TipoConsult = Tipo_Consult;
            TemaConsult = Tema_Consult;
            FechaConsult = Fecha_consulta;
            Hora = Hora_con;
            Numero_Carnet = NumeroCarnet;
            Firma_Estudiante = FirmaEstudiante;
            Observaciones = observa;
            VOBO_jefe = VOBOJEFE;
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
            this.txtHora.Text = this.Hora;
            this.txt_NumCarnet.Text = Numero_Carnet;
            this.txt_FirmaEst.Text = Firma_Estudiante;
            this.txt_Observaciones.Text = Observaciones;
            if (VOBO_jefe == 1)
            {
                this.rbn_Aprobado.Checked = true;
            }
            else
            {
                this.rbn_SinAprobar.Checked = false;
            }

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditarC_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Eliiminar_Load(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
                Eliminar();
        }
        private void Eliminar()
        {
            new CN_Consultas_consul().EliminarConsulta(this.IDConsulta);
            MessageBox.Show("Se ha eliminado con exito");
            this.Hide();//ocultar el que  formulario
        }

        private void Editar()
        {
            new CN_Consultas_consul().EditarConsulta(this.IDConsulta);
            MessageBox.Show("se ha editado con exito");
            this.Hide();
        }
    }
}
