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
    public partial class eventoProximoBackOffice : Form
    {
        public eventoProximoBackOffice()
        {
            InitializeComponent();
        }
        Deporte deporte = new Deporte();
        Equipo equipo = new Equipo();
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");
        DateTime ahora = DateTime.Now.Date;

        public void Agregar ()
        {
            EventoProximo evento = new EventoProximo(fechaEvento.Value, horaEvento.Value, listaDeportes.SelectedItem.ToString(), listaEquipo1.SelectedItem.ToString(), listaEquipo2.SelectedItem.ToString());
            if (!evento.autenticacionEvento())
            {
                evento.agregarEvento();

                string equipo1 = listaEquipo1.SelectedItem.ToString();
                string equipo2 = listaEquipo2.SelectedItem.ToString();
                string zona1 = zonaCombo1.SelectedItem.ToString();
                string zona2 = zonaCombo2.SelectedItem.ToString();

                Equipo team1 = new Equipo(equipo1, zona1);
                Equipo team2 = new Equipo(equipo2, zona2);
                int id1 = Convert.ToInt32(team1.ID());
                int id2 = Convert.ToInt32(team2.ID());

                Deporte sport = new Deporte(listaDeportes.SelectedItem.ToString());
                int idDeporte = Convert.ToInt32(sport.ID());

                int idEvento = Convert.ToInt32(evento.ID());

                ParticipaFijado participa1 = new ParticipaFijado(id1, idEvento, idDeporte);
                participa1.agregarParticipa();
                ParticipaFijado participa2 = new ParticipaFijado(id2, idEvento, idDeporte);
                participa2.agregarParticipa();

                listaEquipo1.ResetText();
                listaEquipo2.ResetText();
                listaDeportes.ResetText();
                listaEquipo1.Enabled = false;
                listaEquipo2.Enabled = false;
                zonaCombo1.Items.Clear();
                zonaCombo2.Items.Clear();
                zonaCombo1.ResetText();
                zonaCombo2.ResetText();
                zonaCombo1.Enabled = false;
                zonaCombo2.Enabled = false;
                MessageBox.Show("Evento creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //

                DataTable origendatos;
                string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Eventofijado";
                MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;
            }
            else
            {
                MessageBox.Show("Ya existe un evento como ese", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listaDeportes.SelectedItem != null &&
               listaEquipo1.SelectedItem != null &&
               listaEquipo2.SelectedItem != null)
            {         
                if(fechaEvento.Value == ahora || fechaEvento.Value > ahora)
                {
                    if(listaEquipo1.SelectedItem.ToString() != listaEquipo2.SelectedItem.ToString())
                    {
                        Agregar();
                    } 
                    else if (zonaCombo1.SelectedItem.ToString() == zonaCombo2.SelectedItem.ToString())
                    {
                        MessageBox.Show("Seleccione Equipos diferentes!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else {Agregar();}
              
                }
                else
                {
                    MessageBox.Show("La fecha es incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("Rellene campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventoProximoBackOffice_Load(object sender, EventArgs e)
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
            string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Eventofijado";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEvento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ParticipaFijado participa1 = new ParticipaFijado(0, idEvento, 0);
            participa1.eliminarParticipa();
            ParticipaFijado participa2 = new ParticipaFijado(0, idEvento, 0);
            participa2.eliminarParticipa();

            EventoProximo evento = new EventoProximo();
            evento.eliminarEvento(idEvento);

            DataTable origendatos;
            string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Eventofijado";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;

            MessageBox.Show("Evento eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listaEquipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            zonaCombo1.Enabled = true;
            zonaCombo1.Items.Clear();

            string nombreEquipo = listaEquipo1.SelectedItem.ToString();
            List<string> list = new List<string>();

            Equipo team = new Equipo();
            list = team.mostrarZona(nombreEquipo);

            foreach (string a in list)
            {
                zonaCombo1.Items.Add(a);
            }
        }

        private void listaEquipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            zonaCombo2.Enabled = true;
            zonaCombo2.Items.Clear();

            string nombreEquipo = listaEquipo2.SelectedItem.ToString();
            List<string> list = new List<string>();

            Equipo team = new Equipo();
            list = team.mostrarZona(nombreEquipo);

            foreach (string a in list)
            {
                zonaCombo2.Items.Add(a);
            }
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

            foreach (string a in lista)
            {
                listaEquipo1.Items.Add(a);
                listaEquipo2.Items.Add(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
