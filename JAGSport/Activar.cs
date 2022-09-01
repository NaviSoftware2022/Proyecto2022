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

        public bool resultado = false;

        public bool Resultado
        {
            get { return resultado; }
        }



        public Activar()
        {
            InitializeComponent();
            resultado = false;
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

            HomeVIP homevip = new HomeVIP();

            if(user.autenticacion())
            {
                user.eliminary();
                userV.agregar();
                userV.autenticacionUser();
                correo = textBox1.Text;
                resultado = true;


                this.Hide();
                homevip.ShowDialog();

    
                
            }
        }
    }
}
