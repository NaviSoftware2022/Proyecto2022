using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JAGSport.HomeVIP;
using static JAGSport.Logica;
using System.Collections;

namespace JAGSport
{
    public partial class FormLogin : Form
    {

        
        Form2 Registrarme = new Form2();

        public FormLogin()
        {
            InitializeComponent();
        }

        public int resultado = 0;

        public int Resultado
        {
            get { return resultado; }
        }


        string correo;
        public string Correo ()
        {        
            return correo;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {    
            Usuario user = new Usuario(textBox1.Text, textBox2.Text);
            UsuarioVIP userV = new UsuarioVIP(textBox1.Text, textBox2.Text, 1);
            UsuarioAdmin userA = new UsuarioAdmin(textBox1.Text, textBox2.Text, "1");
            Home homee = new Home();
            HomeVIP homeVIP = new HomeVIP();
            BackOffice backOffice = new BackOffice();

            if (user.autenticacion())
            {
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
                resultado = 1;
                correo = textBox1.Text;
            }
            else if (userV.autenticacion())
            {
                textBox1.Text = "";
                textBox2.Text = "";
                resultado = 1;
                this.Hide();
                homeVIP.ShowDialog();
            }
            else if (userA.autenticacion())
            {

                textBox1.Text = "";
                textBox2.Text = "";
                resultado = 2;
                this.Hide();
                backOffice.ShowDialog();
            }

            else
            {
                MessageBox.Show("No existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrarme.ShowDialog();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
