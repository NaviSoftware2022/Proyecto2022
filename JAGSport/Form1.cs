using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JAGSport
{
    public partial class Form1 : Form
    {


        Home home = new Home();
        Form2 Registrarme = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root;");

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
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Select correo, contrasenia from Usuario where correo = @vcorreo AND contrasenia = @vcontrasenia", datos);
            comando.Parameters.AddWithValue("@vcorreo", textBox1.Text);
            comando.Parameters.AddWithValue("@vcontrasenia", textBox2.Text);

            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                datos.Close();
                this.Hide();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                datos.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrarme.ShowDialog();
        }
    }
}
