using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4Guia2
{

    public partial class Form1 : Form
    {
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string contra = txtpass.Text;
            string url = "D:\\REPOSITORIOS VS\LAB POO\LAB 2 POO\\" + usuario + ".txt"; //usted elige ubicación de carpeta, la que hizo en el paso 3, pero esta debe existir
            if (File.Exists(url)) //verifica que el archive exista
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado txtuser.Clear(); //limpiamos todos los textbox txtpass.Clear();
            }
            else
            {
                File.WriteAllText(url, contra);
                MessageBox.Show("Usuario Registrado con éxito");
                txtuser.Clear();
                txtpass.Clear();
            }
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text; //capturamos los valores de usuario y contraseña string contra = txtpass.Text;
            string url = "C:\\POO\\" + usuario + ".txt";
            if (File.Exists(url))
            {
                password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo  //verifica si contraseña es igual al archivo {
                if (contra.Equals(password))
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");//login fallido }
                }

            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! "); //usuario incorrecto 
            }
            
        }

        private void btnregreso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
