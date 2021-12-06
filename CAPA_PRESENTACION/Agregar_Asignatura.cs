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
    public partial class Agregar_Asignatura : Form
    {
        //******************VALIDACION**************************************************************************
        public bool Vacio=true;
        public bool Resultado = true;

        public bool Validar(Form formulario)
        {

            foreach (Control controles in formulario.Controls) //Busco el control
            {
                if (controles is TextBox & controles.Text == String.Empty) //Si esta vacio
                {
                    Vacio = false;
                    Resultado = false;
                    MessageBox.Show("Llenar los campos vacios");
                }
                else if (controles is TextBox & controles.Text != String.Empty) //Si no esta vacio
                {
                    Vacio = true;
                    Resultado = true;
                }
            }
            return Resultado;
        }
        //**************************************************************************************************
        public Agregar_Asignatura()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar(this))
            {
                Agregar();
            }
               
        }
        private void Agregar()
        {
            new CN_Asignaturas().AgregarAsignaturas(this.txtNomAsig.Text.Trim());
            MessageBox.Show("Asignatura agregada");
            this.Hide();
        }
    }
}
