using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        form2 usuario = new form2();
        form3 admin = new form3();
        form4 registro = new form4();

        int op = 0, opAn;

        public class Cuenta
        {

            public ArrayList Usuario = new ArrayList();
            public ArrayList Contraseña = new ArrayList();

            public string usuario { get; set; }
            public string contraseña { get; set; }

            public Cuenta() { }

            public Cuenta(string usuario, string contraseña)
            {
                this.usuario = usuario;
                this.contraseña = contraseña;
            }
            
            public void Agregar()
            {
                Usuario.Add(usuario);
                Contraseña.Add(contraseña);
            }

            public void Eliminar()
            {
                Usuario.Remove(usuario);
                Contraseña.Remove(contraseña);
            }

            public bool VerificacionUsuario()
            {

                return (Usuario.Contains(usuario) && Contraseña.Contains(contraseña));
            }

            public bool VerificacionAdmin()
            {
                return usuario == "NaviSoft" && contraseña == "ROOT";
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cuenta login = new Cuenta(textBox1.Text, textBox2.Text);

            if (login.VerificacionUsuario())
            {
                usuario.ShowDialog();
                this.Hide();
            }
            else if (login.VerificacionAdmin())
            {
                admin.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cuenta Inexistente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro.Show();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            opAn = op;
            op = rnd.Next(1, 4);
             while(opAn == op) {
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
    

