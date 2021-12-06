using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class Formulario_reportes : Form
    {
        public Formulario_reportes()
        {
            InitializeComponent();
        }

        private void Formulario_reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosConsultas.Consultas' Puede moverla o quitarla según sea necesario.
            this.ConsultasTableAdapter.Fill(this.DatosConsultas.Consultas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
