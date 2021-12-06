using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIOS;

namespace CAPA_PRESENTACION
{
    public partial class Vista_asignaturas : Form
    {
        public Vista_asignaturas()
        {
            InitializeComponent();
        }

        private void Vista_asignaturas_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            this.DgAsig.DataSource = new CN_Asignaturas().ListarAsignaturas();
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            new Agregar_Asignatura().ShowDialog();//mostramos el formulario
            Listar();
        }
    }
}
