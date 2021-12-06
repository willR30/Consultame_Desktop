using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar las capas
using CAPA_DATOS;
using CAPA_NEGOCIOS;

namespace CAPA_PRESENTACION
{
    public partial class Agregar_consulta : Form
    {
        public Agregar_consulta()
        {
            InitializeComponent();
            CargarCombo();
        }
        private void Agregar_consulta_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }
        //*******************VALIDACION************************************************************
        private void ValidarCampos()
        {
            var vr = !string.IsNullOrEmpty(txtHora.Text) && !string.IsNullOrEmpty(txt_CanEst.Text) &&
                !string.IsNullOrEmpty(txt_FirmaEst.Text) && !string.IsNullOrEmpty(txt_NumCarnet.Text) &&
                !string.IsNullOrEmpty(txt_NumSemanas.Text) && !string.IsNullOrEmpty(txt_Observaciones.Text) &&
                !string.IsNullOrEmpty(txt_TemaConsult.Text);
            btnAgregar.Enabled = vr;
        }
        //**********************************************************************************************
        private void CargarCombo()
        {
            this.cbx_asignaturas.DataSource = new CN_Asignaturas().ListarAsignaturas();
            this.cbx_asignaturas.DisplayMember = "Nombre_Materia";
            this.cbx_asignaturas.ValueMember = "Id_materias";
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
           
        }
        private void Agregar()
        {
            int ID_materias = this.cbx_asignaturas.SelectedIndex;//index de la materia
            
            //rescatamos los datos de la interfaz
            int Numero_semana= Convert.ToInt32(txt_NumSemanas.Text.Trim()), Cantidad_Estudiante=Convert.ToInt32(this.txt_CanEst.Text.Trim());
            string Tipo_consulta = this.cbTipoConsult.SelectedItem.ToString(), Tema_consulta = this.txt_TemaConsult.Text.Trim(),  Hora = this.txtHora.Text.Trim();
            DateTime Fecha = this.dt_Fecha.Value;
            string Numero_Carnet=this.txt_NumCarnet.Text, Firma=this.txt_FirmaEst.Text.Trim(), Observaciones=this.txt_Observaciones.Text.Trim();
            int VoBo_Jefe=0;
            if (this.rbn_Aprobado.Checked == true)
            {
                VoBo_Jefe = 1;//cambiamos el valor solo si la condicion se cumple
            }
            //instanciamos el objeto con el metodo y pasamos los parametros que contienen los valores
            try
            {
                new CN_Consultas_consul().AgregarConsultas(ID_materias+1, Numero_semana, Cantidad_Estudiante,
           Tipo_consulta, Tema_consulta, Fecha, Hora, Numero_Carnet, Firma, Observaciones, VoBo_Jefe);
                MessageBox.Show("Se ha agregado");
                this.Hide();//ocultamos el fomrulario

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
           
        }
        private void txt_NumSemanas_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt_CanEst_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt_NumCarnet_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt_FirmaEst_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt_TemaConsult_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt_Observaciones_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                Agregar();
        }

 
    }
}
