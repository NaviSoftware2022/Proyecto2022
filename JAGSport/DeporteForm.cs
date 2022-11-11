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
    public partial class DeporteForm : Form
    {
        public DeporteForm()
        {
            InitializeComponent();
        }
        Equipo team = new Equipo();
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        public void tabla ()
        {
            DataTable origendatos;
            string query = "select * from Deporte";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (nameDeporte.Text != "")
            {
                string name = nameDeporte.Text.ToLower();
                Deporte deporte = new Deporte(name);

                if (!deporte.autenticacionDeporte())
                {
                    deporte.agregarDeporte();
                    nameDeporte.Text = "";
                    MessageBox.Show("Accion realizada correctamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //

                    DataTable origendatos;
                    string query = "select * from Deporte";
                    MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                    origendatos = new DataTable();
                    adapter.Fill(origendatos);
                    dataGridView1.DataSource = origendatos;
                }
                else
                {
                    nameDeporte.Text = "";
                    MessageBox.Show("Ya existe un deporte con ese nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Rellene Campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DeporteForm_Load(object sender, EventArgs e)
        {
            tabla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Deporte deporte = new Deporte(name);
                Juega game = new Juega("", id);
                Jugador player = new Jugador();

                List<string> listaIdEvento = new List<string>();
                List<string> listaEquipos = new List<string>();

                listaEquipos = game.mostrarEquipos();

                Integra integra = new Integra();

                string idEquipo = team.ID();
                listaIdEvento = deporte.idEvento(Convert.ToInt32(id));

                // Eliminar Participa (Relacion Evento - Deporte - Equipos)
                Participa participa = new Participa(0, 0, Convert.ToInt32(id));
                participa.eliminarParticipaDeporte();

                // Eliminar Eventos 
                foreach (string a in listaIdEvento)
                {
                    Evento evento = new Evento();
                    evento.eliminarEvento(Convert.ToInt32(a));
                }

                List<string> listJugadores = new List<string>();
                List<string> listJugadoresID = new List<string>();

                foreach (string a in listaEquipos)
                {
                    Integra relacionJE = new Integra(0, Convert.ToInt32(a));
                    listJugadores = relacionJE.mostrarJugadores();
                    foreach (string b in listJugadores)
                    {
                        listJugadoresID.Add(b);
                    }
                }

                // Eliminar Integra (Relacion Equipo - Jugador)
                integra.eliminarIntegraEquipo(idEquipo);

                // Eliminar Jugadores con NombreEquipo
                foreach (string c in listJugadoresID)
                {
                    player.eliminarJugadorID(c);
                }

                // ELiminar Juega (Relacion Deporte - Equipo)
                game.eliminarJuegaDeporte();

                // Eliminar Equipos
                foreach (string a in listaEquipos)
                {
                    Equipo team = new Equipo();
                    team.eliminarEquipoID(a);
                }
                // Eliminar Deporte
                deporte.eliminarDeporte(id);


                tabla();

                MessageBox.Show("Deporte eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
