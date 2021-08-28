using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1Guia2
{
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //PARTE INICIAL DE LA GUIA
            //string texto = txtnombre.Text; 
            //MessageBox.Show("Bienvenido a POO " + texto + " este es tu primer formulario");
            string texto = txtnombre.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto); 
            Form2 frmrecibe = new Form2(mensaje); /* creo un objeto del segundo formulario, adonde mando información*/
            frmrecibe.Visible = true; // muestra el nuevo formulario this.Visible = false; // esconde el formulario actual
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
