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
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }
        Deporte deporte = new Deporte();
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            listaDeportes.Items.Clear();
            List<string> listaDeporte = new List<string>();
            listaDeporte = deporte.mostrarDeporte();

            foreach (string a in listaDeporte)
            {
                listaDeportes.Items.Add(a);
            }

            DataTable origendatos;
            string query = "select nombreEquipo, zona, nombreDeporte from Equipo a, Deporte b, Juega c where a.idEquipo = c.idEquipo and b.idDeporte = c.idDeporte";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if(nameTeam.Text != "" && listaDeportes.SelectedIndex.ToString() != null && zonaT.Text != "")
            {
                string name = nameTeam.Text.ToLower();
                string zona = zonaT.Text.ToLower();
                Equipo team = new Equipo(name, zona);
                Deporte sport = new Deporte(listaDeportes.SelectedItem.ToString());

                if (!team.autenticacionEquipo())
                {
                    team.agregarEquipo(listaDeportes.SelectedItem.ToString());
                    nameTeam.Text = "";
                    zonaT.Text = "";
                    listaDeportes.ResetText();
                    string id1 = team.ID();
                    string id2 = sport.ID();
                    Juega play = new Juega(id1, id2);
                    play.agregarJuega();

                    MessageBox.Show("Equipo creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //
                    DataTable origendatos;
                    string query = "select nombreEquipo, zona,  nombreDeporte from Equipo a, Deporte b, Juega c where a.idEquipo = c.idEquipo and b.idDeporte = c.idDeporte";
                    MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                    origendatos = new DataTable();
                    adapter.Fill(origendatos);
                    dataGridView1.DataSource = origendatos;
                } else
                {
                    MessageBox.Show("Ya existe un equipo con ese nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Rellene campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nameTeam = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string zona = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

            List<string> listaIdEvento = new List<string>();
            Equipo team = new Equipo(nameTeam, zona);
            string id1 = team.ID();

            Integra gameplayer = new Integra(0, Convert.ToInt32(id1));
            string idJugador = gameplayer.mostrarJugador();

            Juega game = new Juega(id1, "");
            listaIdEvento = team.idEvento(Convert.ToInt32(id1));   
            
            foreach (string a in listaIdEvento)
            {
                // Eliminar Participa (Relacion Evento - Deporte - Equipos)
                Participa participa = new Participa(0, Convert.ToInt32(a), 0);
                participa.eliminarParticipa();

                // Eliminar Eventos 
                Evento evento = new Evento();
                evento.eliminarEvento(Convert.ToInt32(a));
            }


            // Eliminar Integra (Relacion Equipo - Jugador)
            Integra integra = new Integra();
            integra.eliminarIntegraEquipo(id1);


            // Eliminar Jugadores con ese Equipo
            Jugador player = new Jugador();
            player.eliminarJugadorID(idJugador);

            // Eliminar Juega (Relacion Deporte - Equipo)
            game.eliminarJuega();

            // Eliminar Equipo
            team.eliminarEquipo();

            DataTable origendatos;
            string query = "select nombreEquipo, zona, nombreDeporte from Equipo a, Deporte b, Juega c where a.idEquipo = c.idEquipo and b.idDeporte = c.idDeporte";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;

            MessageBox.Show("Equipo eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
