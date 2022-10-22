using MySql.Data.MySqlClient;
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
    public partial class Jugadores : Form
    {
        public Jugadores()
        {
            InitializeComponent();
        }
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root;");

        private void button1_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador(teamNombre.Text, teamApellido.Text, Convert.ToInt32(teamEdad.Text), Convert.ToInt32(teamNumCam.Text), teamPais.Text, teamPosicion.Text, teamEquipo.Text, teamNacimiento.Text);
            jugador.AgregarJugador();
          
        }

        private void Jugadores_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select nombre, apellido, nacionalidad from Jugador";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }
    }
}
