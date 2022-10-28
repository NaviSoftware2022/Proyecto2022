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
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root;");
        Equipo equipo = new Equipo();
        Jugador player = new Jugador();
        Integra integra = new Integra();
        int id1 = 0;
        int id2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {


            if(teamNombre.Text != "" && teamApellido.Text != "" && teamEdad.Text != "" && teamNumCam.Text != "" && teamPais.Text != "" && listaEquipoBox.SelectedItem.ToString() != "")
            {
                player = new Jugador(teamNombre.Text, teamApellido.Text, Convert.ToInt32(teamEdad.Text), Convert.ToInt32(teamNumCam.Text), teamPais.Text, listaEquipoBox.SelectedItem.ToString(), timePicker.Value);
                Equipo team = new Equipo(listaEquipoBox.SelectedItem.ToString());


                player.AgregarJugador();

                id1 = player.ID();
                id2 = Convert.ToInt32(team.ID());

                integra = new Integra(id1, id2);
                integra.agregarIntegra();

                MessageBox.Show("Jugador registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teamNombre.Text = "";
                teamApellido.Text = "";
                teamEdad.Text = "";
                teamNumCam.Text = "";
                teamPais.Text = "";
                listaEquipoBox.ResetText();
                timePicker.ResetText();

                //
                DataTable origendatos;
                string query = "select nombre, apellido, nacionalidad, nacimiento, equipo from Jugador";
                MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
                origendatos = new DataTable();
                adapter.Fill(origendatos);
                dataGridView1.DataSource = origendatos;
            } else
            {
                MessageBox.Show("Rellene campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void Jugadores_Load(object sender, EventArgs e)
        {
            
            List<string> listaEquipo = new List<string>();
            listaEquipo = equipo.mostrarEquipo();

            foreach (string a in listaEquipo)
            {
                listaEquipoBox.Items.Add(a);
            }

            DataTable origendatos;
            string query = "select nombre, apellido, nacionalidad, nacimiento, equipo from Jugador";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreJ = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string apellidoJ = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            string nacionalidadJ = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            DateTime nacimientoJ = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            string equipoJ = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);

            Jugador player = new Jugador(nombreJ, apellidoJ, 1, 1, nacionalidadJ, equipoJ, nacimientoJ);
            int id = player.ID();
            Integra integra = new Integra(id, 0);
            integra.eliminarIntegra();
            player.eliminarJugador();

            MessageBox.Show("Jugador eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //
            DataTable origendatos;
            string query = "select nombre, apellido, nacionalidad, nacimiento, equipo from Jugador";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }
    }
}
