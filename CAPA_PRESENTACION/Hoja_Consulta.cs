using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIOS;//nos conectamos con a capa de negocios para acceder a tordos los metodos disponibles
using CAPA_DATOS;//importamos el modelo


namespace CAPA_PRESENTACION
{
    public partial class Hoja_Consulta : Form
    {
        List<Modelo> Registros = new List<Modelo>();//lista donde se van a guardar los regustros

        public Hoja_Consulta()
        {
            InitializeComponent();

        }

        private void Hoja_Consulta_Load(object sender, EventArgs e)
        {
            ListarRegistros();
            CargarCombo();
            this.cbx_num_semana.SelectedItem = 1;
        }
        private void CargarCombo()
        {
            this.cbx_asignaturas.DataSource = new CN_Asignaturas().ListarAsignaturas();
            this.cbx_asignaturas.DisplayMember = "Nombre_Materia";
            this.cbx_asignaturas.ValueMember = "Id_materias";
        }
        private void ListarRegistros()
        {
            //cargamos los regisros
            Registros = new CN_Consultas_consul().ListarConsultas();//rescatamos los registros de la capa de negocio, que a su vez los rescata de la capa datos y esta asu vez de la base de datos
            //mostramos los registros dentro de la tabla
            int Contador = 0;//intanciamos un contador para controlar las filas de la datagrid

            LimpiarDataGrid();//limpiamos el dtgrdi
            //recorremos la lista porcada objeto de la fila
            foreach (var item in Registros)
            {
                //comenzamos a contruir la tabla
                //agregamos un rows
                this.DgDatos.Rows.Add();
                this.DgDatos.Rows[Contador].Cells[0].Value = item.Id.ToString();
                //.DgDatos.Rows[Contador].Cells[1].Value = item.ID_materias.ToString();
                this.DgDatos.Rows[Contador].Cells[1].Value = item.NumeroSemana.ToString();
                this.DgDatos.Rows[Contador].Cells[2].Value = item.Cantidad_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[3].Value = item.Tipo_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[4].Value = item.Tema_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[5].Value = item.Fecha_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[6].Value = item.Hora.ToString();
                this.DgDatos.Rows[Contador].Cells[7].Value = item.Carnet_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[8].Value = item.Firma_estudiante.ToString();
                this.DgDatos.Rows[Contador].Cells[9].Value = item.Observaciones.ToString();
                this.DgDatos.Rows[Contador].Cells[10].Value = item.ViBo_JefeDepto.ToString();
                Contador++;
            }
        }
        private void ListarRegistros_PorMaterias()
        {
            int ID_materias = this.cbx_asignaturas.SelectedIndex;
            //cargamos los regisros
            Registros = new CN_Consultas_consul().ObtenerREgistros_porMaterias(ID_materias+1);//rescatamos los registros de la capa de negocio, que a su vez los rescata de la capa datos y esta asu vez de la base de datos
            //mostramos los registros dentro de la tabla
            int Contador = 0;//intanciamos un contador para controlar las filas de la datagrid

            LimpiarDataGrid();//limpiamos el dtgrdi
            //recorremos la lista porcada objeto de la fila
            foreach (var item in Registros)
            {
                //comenzamos a contruir la tabla
                //agregamos un rows
                this.DgDatos.Rows.Add();
                this.DgDatos.Rows[Contador].Cells[0].Value = item.Id.ToString();
                //.DgDatos.Rows[Contador].Cells[1].Value = item.ID_materias.ToString();
                this.DgDatos.Rows[Contador].Cells[1].Value = item.NumeroSemana.ToString();
                this.DgDatos.Rows[Contador].Cells[2].Value = item.Cantidad_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[3].Value = item.Tipo_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[4].Value = item.Tema_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[5].Value = item.Fecha_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[6].Value = item.Hora.ToString();
                this.DgDatos.Rows[Contador].Cells[7].Value = item.Carnet_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[8].Value = item.Firma_estudiante.ToString();
                this.DgDatos.Rows[Contador].Cells[9].Value = item.Observaciones.ToString();
                this.DgDatos.Rows[Contador].Cells[10].Value = item.ViBo_JefeDepto.ToString();
                Contador++;
            }
        }
        private void ListarRegistros_PorCarnet()
        {

            //cargamos los regisros
            Registros = new CN_Consultas_consul().ObtenerREgistros_porCarnet(this.txt_carnet_estudiante.Text);//rescatamos los registros de la capa de negocio, que a su vez los rescata de la capa datos y esta asu vez de la base de datos
            //mostramos los registros dentro de la tabla
            int Contador = 0;//intanciamos un contador para controlar las filas de la datagrid

            LimpiarDataGrid();//limpiamos el dtgrdi
            //recorremos la lista porcada objeto de la fila
            foreach (var item in Registros)
            {
                //comenzamos a contruir la tabla
                //agregamos un rows
                this.DgDatos.Rows.Add();
                this.DgDatos.Rows[Contador].Cells[0].Value = item.Id.ToString();
                //.DgDatos.Rows[Contador].Cells[1].Value = item.ID_materias.ToString();
                this.DgDatos.Rows[Contador].Cells[1].Value = item.NumeroSemana.ToString();
                this.DgDatos.Rows[Contador].Cells[2].Value = item.Cantidad_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[3].Value = item.Tipo_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[4].Value = item.Tema_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[5].Value = item.Fecha_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[6].Value = item.Hora.ToString();
                this.DgDatos.Rows[Contador].Cells[7].Value = item.Carnet_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[8].Value = item.Firma_estudiante.ToString();
                this.DgDatos.Rows[Contador].Cells[9].Value = item.Observaciones.ToString();
                this.DgDatos.Rows[Contador].Cells[10].Value = item.ViBo_JefeDepto.ToString();
                Contador++;
            }
        }
        private void ListarRegistros_PorSemana()
        {
            int NSemana = Convert.ToInt32(this.cbx_num_semana.SelectedItem.ToString());
            //cargamos los regisros
            Registros = new CN_Consultas_consul().ObtenerREgistros_porSemana(NSemana);//rescatamos los registros de la capa de negocio, que a su vez los rescata de la capa datos y esta asu vez de la base de datos
            //mostramos los registros dentro de la tabla
            int Contador = 0;//intanciamos un contador para controlar las filas de la datagrid

            LimpiarDataGrid();//limpiamos el dtgrdi
            //recorremos la lista porcada objeto de la fila
            foreach (var item in Registros)
            {
                //comenzamos a contruir la tabla
                //agregamos un rows
                this.DgDatos.Rows.Add();
                this.DgDatos.Rows[Contador].Cells[0].Value = item.Id.ToString();
                //.DgDatos.Rows[Contador].Cells[1].Value = item.ID_materias.ToString();
                this.DgDatos.Rows[Contador].Cells[1].Value = item.NumeroSemana.ToString();
                this.DgDatos.Rows[Contador].Cells[2].Value = item.Cantidad_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[3].Value = item.Tipo_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[4].Value = item.Tema_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[5].Value = item.Fecha_consulta.ToString();
                this.DgDatos.Rows[Contador].Cells[6].Value = item.Hora.ToString();
                this.DgDatos.Rows[Contador].Cells[7].Value = item.Carnet_estudiantes.ToString();
                this.DgDatos.Rows[Contador].Cells[8].Value = item.Firma_estudiante.ToString();
                this.DgDatos.Rows[Contador].Cells[9].Value = item.Observaciones.ToString();
                this.DgDatos.Rows[Contador].Cells[10].Value = item.ViBo_JefeDepto.ToString();
                Contador++;
            }
        }
        private void LimpiarDataGrid()
        {
            this.DgDatos.Rows.Clear();//limpiamos todas las columas
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            Agregar_consulta add_consult = new Agregar_consulta();
            add_consult.ShowDialog();
            ListarRegistros();
        }

        private void DgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //al hacer doble clik accedemos al formulario para eliminar y editar una consulta
            try
            {
                int ID_consulta = Convert.ToInt32(this.DgDatos.CurrentRow.Cells[0].Value.ToString());
                int Numero_Sem = Convert.ToInt32(this.DgDatos.CurrentRow.Cells[1].Value.ToString());
                int Cantidad_estud = Convert.ToInt32(this.DgDatos.CurrentRow.Cells[2].Value.ToString());
                string Tipo_Consulta = (this.DgDatos.CurrentRow.Cells[3].Value.ToString());
                string Tema_Consulta = (this.DgDatos.CurrentRow.Cells[4].Value.ToString());
                DateTime Fecha = Convert.ToDateTime(this.DgDatos.CurrentRow.Cells[5].Value.ToString());
                string Hora=this.DgDatos.CurrentRow.Cells[6].Value.ToString();
                string NumeroCarnetEstudiante = this.DgDatos.CurrentRow.Cells[7].Value.ToString();
                string FirmaEstudiante= this.DgDatos.CurrentRow.Cells[8].Value.ToString();
                string Observaciones= this.DgDatos.CurrentRow.Cells[9].Value.ToString();
                int VOBO_jefe=Convert.ToInt32(this.DgDatos.CurrentRow.Cells[10].Value.ToString());
                new Editar_Eliiminar(ID_consulta,Numero_Sem,Cantidad_estud,Tipo_Consulta,Tema_Consulta,Fecha,Hora,NumeroCarnetEstudiante,FirmaEstudiante,Observaciones,VOBO_jefe).ShowDialog();//gacemos visible el formulario
                ListarRegistros();
            }
            catch(Exception ex)//aqui capturamos el error
            {
                MessageBox.Show(""+ex);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbx_Asginaturas.Checked == true)
            {
                cbx_asignaturas.Visible = true;
            }
            else
            {
                cbx_asignaturas.Visible = false;
            }
        }

        private void rbx_num_semanas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbx_num_semanas.Checked == true)
            {
                this.cbx_num_semana.Visible = true;
            }
            else
            {
                this.cbx_num_semana.Visible = false;
            }
        }

        private void rbx_carnet_estudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbx_carnet_estudiante.Checked == true)
            {
                this.txt_carnet_estudiante.Visible = true;
                this.btn_buscar.Visible = true;
            }
            else
            {
                this.txt_carnet_estudiante.Visible = false;
                this.btn_buscar.Visible = false;
            }
        }

        private void rbx_fecha_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void DgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_carnet_estudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbx_asignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarRegistros_PorMaterias();
        }

        private void cbx_num_semana_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarRegistros_PorSemana();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarRegistros_PorCarnet();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            this.ListarRegistros();
        }
    }
}
