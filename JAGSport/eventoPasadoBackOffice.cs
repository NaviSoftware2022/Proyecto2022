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
    public partial class eventoPasadoBackOffice : Form
    {
        public eventoPasadoBackOffice()
        {
            InitializeComponent();
        }
        Deporte deporte = new Deporte();
        Equipo equipo = new Equipo();
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void eventoPasadoBackOffice_Load(object sender, EventArgs e)
        {
            List<string> listaDeporte = new List<string>();
            List<string> listaEquipo = new List<string>();
            listaDeporte = deporte.mostrarDeporte();
            listaEquipo = equipo.mostrarEquipo();

            listaDeportes.Items.Clear();
            foreach (string a in listaDeporte)
            {
               listaDeportes.Items.Add(a); 
            }

            DataTable origendatos;
            string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Evento";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if(listaDeportes.SelectedItem != null &&
                listaEquipo1.SelectedItem != null &&
                listaEquipo2.SelectedItem != null)
            {
                Evento evento = new Evento(fechaEvento.Value, horaEvento.Value, listaDeportes.SelectedItem.ToString(), Convert.ToInt32(resultado1.Value), Convert.ToInt32(resultado2.Value), listaEquipo1.SelectedItem.ToString(), listaEquipo2.SelectedItem.ToString());
                if(!evento.autenticacionEvento())
                {
                    evento.agregarEvento();

                    string equipo1 = listaEquipo1.SelectedItem.ToString();
                    string equipo2 = listaEquipo2.SelectedItem.ToString();

                    Equipo team1 = new Equipo(equipo1);
                    Equipo team2 = new Equipo(equipo2);
                    int id1 = Convert.ToInt32(team1.ID());
                    int id2 = Convert.ToInt32(team2.ID());

                    Deporte sport = new Deporte(listaDeportes.SelectedItem.ToString());
                    int idDeporte = Convert.ToInt32(sport.ID());

                    int idEvento = Convert.ToInt32(evento.ID());

                    Participa participa1 = new Participa(id1, idEvento, idDeporte);
                    participa1.agregarParticipa();
                    Participa participa2 = new Participa(id2, idEvento, idDeporte);
                    participa2.agregarParticipa();

                    listaEquipo1.ResetText();
                    listaEquipo2.ResetText();
                    listaDeportes.ResetText();
                    listaEquipo1.Enabled = false;
                    listaEquipo2.Enabled = false;
                    resultado2.Value = 0;
                    resultado1.Value = 0;
                    MessageBox.Show("Evento creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //

                    DataTable origendatos;
                    string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Evento";
                    MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                    origendatos = new DataTable();
                    adapter.Fill(origendatos);
                    dataGridView1.DataSource = origendatos;

                    
                } else
                {
                    MessageBox.Show("Ya existe un evento como ese", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
            } else
            {
                MessageBox.Show("Rellene campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            Participa participa1 = new Participa(0, idEvento, 0);
            participa1.eliminarParticipa();
            Participa participa2 = new Participa(0, idEvento, 0);
            participa2.eliminarParticipa();

            Evento evento = new Evento();
            evento.eliminarEvento(idEvento);

            DataTable origendatos;
            string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Evento";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void listaDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaEquipo1.Items.Clear();
            listaEquipo2.Items.Clear();

            List<string> lista = new List<string>();
            listaEquipo1.Enabled = true;
            listaEquipo2.Enabled = true;

            Deporte sport = new Deporte(listaDeportes.SelectedItem.ToString());
            lista = sport.mostrarEquiposDeporte();

            foreach(string a in lista)
            {
                listaEquipo1.Items.Add(a);
                listaEquipo2.Items.Add(a);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
