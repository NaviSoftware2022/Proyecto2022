using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JAGSport.Logica;

namespace JAGSport
{
    public partial class Activar : Form
    {




        public Activar()
        {
            InitializeComponent();
        }

        public int resultado = 0;

        public int Resultado
        {
            get { return resultado; }
        }


        public string correo = "";

        public string Correo
        {
            get { return correo; }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario(textBox1.Text, textBox2.Text);
            UsuarioVIP userV = new UsuarioVIP(textBox1.Text, textBox2.Text, 1);

            Home home = new Home();

            if(user.autenticacion())
            {
                user.eliminary();
                userV.agregar();
                userV.autenticacionUser();
                correo = textBox1.Text;
                resultado = 1;

                this.Hide();
    
            }
        }
    }
}
