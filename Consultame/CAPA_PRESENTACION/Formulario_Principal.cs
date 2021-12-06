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
    public partial class Formulario_Principal : Form
    {
        public Formulario_Principal()
        {
            InitializeComponent();
        }

        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            //instanciamos un objeto para comunicarnos con el formulario que contiene las consultas 
            Form Hoja = new Hoja_Consulta();
            AbrirForm_EnPanel(Hoja);
            //esto prueba la conexion a la base de datos
          //  new PruebaConect().PruebaConeccion();
        }
        //open the other forms inside the panel contens
        private void AbrirForm_EnPanel(object formHijo)
        {
            if (this.panel_center.Controls.Count > 0)
                this.panel_center.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_center.Controls.Add(fh);
            this.panel_center.Tag = fh;
            fh.Show();
        }//fin metodo

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            //instanciamos un objeto para comunicarnos con el formulario que contiene las consultas 
            Form Hoja = new Hoja_Consulta();
            AbrirForm_EnPanel(Hoja);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form Home = new Home();
            AbrirForm_EnPanel(Home);
        }
    }
}
