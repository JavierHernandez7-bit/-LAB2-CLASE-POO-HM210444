using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejemplo1Guia2
{
    public partial class Form2 : Form
    {
        private object lbrecibido;

        public Form2(string textx)
        {
            InitializeComponent(); lbrecibido.Text = textx; // Asignamos lo recibido al label
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmventana form1 = new frmventana(); //instanciamos al primer formulario this.Close(); 
            //cerramos el formulario actual
            form1.Visible = true; //hacemos visible al form1 de nuevo
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }
    }
}
