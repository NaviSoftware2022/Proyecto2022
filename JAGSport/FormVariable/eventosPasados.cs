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

namespace JAGSport.FormVariable
{
    public partial class eventosPasados : Form
    {
        public eventosPasados()
        {
            InitializeComponent();
        }

        public static string idEvento;
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void eventosPasados_Load(object sender, EventArgs e)
        {

            datos.Open();
            MySqlCommand comando = new MySqlCommand("select fecha ,hora, nombreDeporte, resultado1, resultado2, equipo1, equipo2 from Evento where idEvento = @id", datos);
            comando.Parameters.AddWithValue("@id", idEvento);
            MySqlDataReader lector = comando.ExecuteReader();

            int resultado1V = 0, resultado2V = 0;
            string team1V = "", team2V = "";

            if (lector.Read())
            {
                fechaEve.Text = Convert.ToString(lector["fecha"]);
                horaEve.Text = Convert.ToString(lector["hora"]);
                deporteEve.Text = Convert.ToString(lector["nombreDeporte"]);
                resultado1V = Convert.ToInt32(lector["resultado1"]);
                resultado2V = Convert.ToInt32(lector["resultado2"]);
                team1.Text = Convert.ToString(lector["equipo1"]);
                team2.Text = Convert.ToString(lector["equipo2"]);
                team1V= Convert.ToString(lector["equipo1"]);
                team2V = Convert.ToString(lector["equipo2"]);
            }
            resultado1.Text = resultado1V.ToString();
            resultado2.Text = resultado2V.ToString();

            if(resultado1V > resultado2V)
            {
                ganador1.Visible = true;
                perdedor2.Visible = true;
            } else if(resultado2V > resultado1V)
            {
                ganador2.Visible = true;
                perdedor1.Visible = true;
            } else
            {
                empate.Visible = true;
            }

            datos.Close();

            // DATOS LUGAR
            List<string> listLugar = new List<string>();
            Pasa pasa = new Pasa("", idEvento);
            string idLugar = pasa.obtenerIDLugar();

            Ubicacion lugar = new Ubicacion();
            listLugar = lugar.mostrarDatosLugar(idLugar);

            estadio.Text = listLugar[0];
            pais.Text = listLugar[1];




            List<string> list = new List<string>();
            Participa participa = new Participa(0, Convert.ToInt32(idEvento), 0);
            list = participa.mostrarEquipos();
            string idTeam1 = list[0];
            string idTeam2 = list[1];

            DataTable origendatos;
            MySqlCommand cmdSelect = new MySqlCommand("select a.idJugador, a.nombre, a.apellido, a.nacionalidad from jugador a, equipo b, integra c where a.idJugador=c.idJugador and b.idEquipo = c.idEquipo and b.idEquipo = @id;", datos);
            cmdSelect.Parameters.AddWithValue("@id", idTeam1);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            jugador1.DataSource = origendatos;

            DataTable origendatos2;
            MySqlCommand cmdSelect2 = new MySqlCommand("select a.idJugador, a.nombre, a.apellido, a.nacionalidad from jugador a, equipo b, integra c where a.idJugador=c.idJugador and b.idEquipo = c.idEquipo and b.idEquipo = @id;", datos);
            cmdSelect2.Parameters.AddWithValue("@id", idTeam2);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmdSelect2);
            origendatos2 = new DataTable();
            adapter2.Fill(origendatos2);
            jugador2.DataSource = origendatos2;
        }

        private void team2_Click(object sender, EventArgs e)
        {

        }

        private void resultado1_Click(object sender, EventArgs e)
        {

        }

        private void jugador1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = jugador1.CurrentRow.Cells[0].Value.ToString();

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PlayerStats player = new PlayerStats();
                JAGSport.FormVariable.PlayerStats.idPJ = id;
                player.ShowDialog();
            }
        }

        private void jugador2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = jugador2.CurrentRow.Cells[0].Value.ToString();

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PlayerStats player = new PlayerStats();
                JAGSport.FormVariable.PlayerStats.idPJ = id;
                this.Hide();
                player.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
