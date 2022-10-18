using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = abrir.FileName;
                pictureBox2.Image = new Bitmap(abrir.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"C:\Users\USUARIO\source\repos\WindowsFormsApp2\WindowsFormsApp2\Properties\Publicidad\", Path.GetFileName(textBox1.Text)), true);
            label2.Text = "La publicidad ha sido agregada";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label2.Text = "La publicidad ha sido Eliminada";
        }
    }
}
