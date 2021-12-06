using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//librería de entrada y salida 

namespace CAPA_PRESENTACION
{
    public partial class Vista_activacion : Form
    {
        public Vista_activacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validamos los campos nulos
            if (this.txt_codigo.Text == "")
            {
                MessageBox.Show("Debes insertar el codigo de activación");
            }
            else
            {//se llama metodo para activar y se le pasa el código del usuario 
                Activacion(this.txt_codigo.Text.Trim());
            }
            
        }
        private void Activacion(string user_code)
        {
            //aqui se descargará el codigo de verificacion
            WebClient wb = new WebClient();    
            //                                                                  DE donde se descarga /google drive                                                      donde se guarda
            wb.DownloadFile("https://drive.google.com/uc?id=1RMw0g2YA2TXgjl0mYqfdqUqS-mCn4alI", @"C:\ProgramData\Codigo_consultame.txt");
            leer_codigo(user_code);
        }
        private void leer_codigo(string user_code)//mandamos a llamar este codigo desde el metodo de descarga 
        {
            //Leemos el fichero que se descargó y guardamos lo que encontrams en el
            string server_code = System.IO.File.ReadAllText("C:\\ProgramData\\Codigo_consultame.txt").Trim();

            verificacion(user_code, server_code);


        }
        //comparamos que se descargó con el que ingresó el usuario
        private void verificacion(string user_code, string server_code)
        {

            if (user_code == server_code)
            {
                MessageBox.Show("Activacion exitosa");

                new Formulario_Principal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El producto no pudo ser activado");
                this.txt_codigo.Clear();
            }
            DeleteActivationcodeFile();

        }
        private void DeleteActivationcodeFile()
        {
            //this nethod will delete the code activtion file in the computer
            // se busca la ruta y con puntero se borra
            string ruta = "C:\\ProgramData\\Codigo_consultame.txt";
            File.Delete(ruta);
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
