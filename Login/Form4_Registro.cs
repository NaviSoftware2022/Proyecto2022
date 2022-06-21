using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static Login.Form1;

namespace Login
{
    public partial class form4 : Form
    {

        public form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuenta a = new Cuenta();
         
            Cuenta registro = new Cuenta(correoBox.Text,contraseniaBox.Text);

            registro.Agregar();

        }
    }
}
