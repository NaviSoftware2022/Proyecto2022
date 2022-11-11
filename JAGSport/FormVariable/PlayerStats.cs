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
    public partial class PlayerStats : Form
    {
        public PlayerStats()
        {
            InitializeComponent();
        }
        public static string idPJ;
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");
        string teamPJ;
        private void PlayerStats_Load(object sender, EventArgs e)
        {
            
            datos.Open();
            MySqlCommand comando = new MySqlCommand("select nombre, apellido, edad, nroCamiseta, nacionalidad, equipo, nacimiento from Jugador where idJugador = @id", datos);
            comando.Parameters.AddWithValue("@id", idPJ);
            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                namePJ.Text = Convert.ToString(lector["nombre"]);
                lastnamePJ.Text = Convert.ToString(lector["apellido"]);
                edadPJ.Text = Convert.ToString(lector["edad"]);
                camisetaPJ.Text = Convert.ToString(lector["nroCamiseta"]);
                nacionalidadPJ.Text = Convert.ToString(lector["nacionalidad"]);
                teamPJ = Convert.ToString(lector["equipo"]);
                equipoPJ.Text = teamPJ;
            }

            datos.Close();

            Integra integra = new Integra(Convert.ToInt32(idPJ), 0);
            string idTeam = integra.mostrarEquipo();

            Equipo team = new Equipo();
            zonaLabel.Text = team.mostrarZonaID(idTeam);

            DataTable origendatos;
            MySqlCommand cmdSelect = new MySqlCommand("select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Evento where equipo1 = @t1 or equipo2 = @t2 ", datos);
            cmdSelect.Parameters.AddWithValue("@t1", teamPJ);
            cmdSelect.Parameters.AddWithValue("@t2", teamPJ);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eventosPasados evento = new eventosPasados();
                JAGSport.FormVariable.eventosPasados.idEvento = id;
                this.Hide();
                evento.ShowDialog();
            }
        }
    }
}
