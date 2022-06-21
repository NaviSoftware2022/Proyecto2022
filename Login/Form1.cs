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

        public class Cuenta
        {

            ArrayList Usuario = new ArrayList();
            ArrayList Contraseña = new ArrayList();

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
                int x = 0;
                foreach (string var in Usuario)
                {
                    if (var == usuario) { x++; }
                }
                foreach (string var in Contraseña)
                {
                    if (var == contraseña) { x++; }
                }

                return x == 2;
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
            registro.ShowDialog();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    

