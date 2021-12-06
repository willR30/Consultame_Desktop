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
                new Editar_Eliiminar(ID_consulta,Numero_Sem,Cantidad_estud,Tipo_Consulta,Tema_Consulta,Fecha).ShowDialog();//gacemos visible el formulario
                ListarRegistros();
            }
            catch(Exception ex)//aqui capturamos el error
            {
                MessageBox.Show(""+ex);
            }
            
        }
    }
}
