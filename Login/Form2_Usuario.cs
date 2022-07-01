using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Login
{
    public partial class form2 : Form
    {
      
        public form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int op = 0, opAn;
            Random rnd = new Random();
            opAn = op;
            op = rnd.Next(1, 4);
            while (opAn == op)
            {
                op = rnd.Next(1, 4);
            }
            switch (op)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.publi1;
                    pictureBox2.Image = Properties.Resources.publi1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.publi2;
                    pictureBox2.Image = Properties.Resources.publi2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.publi3;
                    pictureBox2.Image = Properties.Resources.publi3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.publi4;
                    pictureBox2.Image = Properties.Resources.publi4;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Rotar ()
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Refresh();
        }
    }
}
