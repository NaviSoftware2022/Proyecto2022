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

namespace JAGSport.FormVariable
{
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
        }

        static MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root;");

        public static string name;
        public static string id;

        private void Teams_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            MySqlCommand comando = new MySqlCommand("select nombreJugador, nroCamiseta, edad from integra a, jugador b where a.idEquipo = @team and a.idJugador = b.idJugador", datos);
            comando.Parameters.AddWithValue("@team", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            gridTeam.DataSource = origendatos;


            //JUGADORES

            datos.Open();
            MySqlCommand comando2 = new MySqlCommand("select nombreDeporte from deporte a, equipo b where a.idDeporte = b.idDeporte and idEquipo = @team1;", datos);
            comando2.Parameters.AddWithValue("@team1", id);
            MySqlDataReader lector = comando2.ExecuteReader();
            lector.Read();
            deporteTeam.Text = lector.GetString(0);
            datos.Close();

            nameTeam.Text = name;
            idTeam.Text = id;
        }
    }
}
