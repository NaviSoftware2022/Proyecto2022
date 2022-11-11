using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        static MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root;");

        public static string name;
        public static string id;

        private void Teams_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            MySqlCommand comando = new MySqlCommand("select b.idJUgador, nombre, nroCamiseta, edad from integra a, jugador b where a.idEquipo = @team and a.idJugador = b.idJugador", datos);
            comando.Parameters.AddWithValue("@team", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            gridTeam.DataSource = origendatos;


            //JUGADORES
            string nombreEquipo = "", zonaEquipo = "";

            datos.Open();
            MySqlCommand comando2 = new MySqlCommand("select deporteName, zona from Equipo where idEquipo = @team1;", datos);
            comando2.Parameters.AddWithValue("@team1", id);
            MySqlDataReader lector = comando2.ExecuteReader();

            if (lector.Read())
            {
                nombreEquipo = Convert.ToString(lector["deporteName"]);
                zonaEquipo = Convert.ToString(lector["zona"]);
            }

            nombreEquipo = nombreEquipo.Substring(0, 1).ToUpper() + nombreEquipo.Substring(1).ToLower();
            deporteTeam.Text = nombreEquipo;

            zonaEquipo = zonaEquipo.Substring(0, 1).ToUpper() + zonaEquipo.Substring(1).ToLower();
            zonatxt.Text = zonaEquipo;

            datos.Close();

            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            nameTeam.Text = name;
        }

        private void gridTeam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = gridTeam.CurrentRow.Cells[0].Value.ToString();

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JAGSport.FormVariable.PlayerStats.idPJ = id;
                PlayerStats player = new PlayerStats();
                this.Hide();
                player.ShowDialog();
            }
        }
    }
}
