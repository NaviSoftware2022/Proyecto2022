using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Login.Form1;

namespace Login
{
    public partial class form3 : Form
    {
        
        public form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string contra = textBox2.Text;
            Cuenta registro = new Cuenta(user, contra);

            registro.Agregar();

            textBox1.Clear();
            textBox2.Clear();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string contra = textBox2.Text;
            Cuenta registro = new Cuenta(user, contra);

            registro.Eliminar();

            textBox1.Clear();
            textBox2.Clear();
        }

        private void form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
