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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root;");


        public void Registro()
        {
            datos.Close();
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Insert into Usuario values(@vcorreo, @vcontrasenia)", datos);
            comando.Parameters.AddWithValue("@vcorreo", correoBox.Text);
            comando.Parameters.AddWithValue("@vcontrasenia", contraseniaBox.Text);
            comando.ExecuteNonQuery();

            this.Hide();

        }

        private void botonCorreo_Click(object sender, EventArgs e)
        {
            datos.Open();
            MySqlCommand comando = new MySqlCommand("Select correo, contrasenia from Usuario where correo = @vcorreo AND contrasenia = @vcontrasenia", datos);
            comando.Parameters.AddWithValue("@vcorreo", correoBox.Text);
            comando.Parameters.AddWithValue("@vcontrasenia", contraseniaBox.Text);

            MySqlDataReader lector = comando.ExecuteReader();
            

            if (lector.Read())
            {
                MessageBox.Show("ya existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoBox.Text = "";
                contraseniaBox.Text = "";
                datos.Close();
            }
            else
            {
               
                Registro();
            }
        }
    }
}
