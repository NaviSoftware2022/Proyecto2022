using JAGSport.FormVariable;
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

namespace JAGSport
{
    public partial class vistaJugadores : Form
    {
        public vistaJugadores()
        {
            InitializeComponent();
        }
        PlayerStats player = new PlayerStats();
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void vistaJugadores_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select idJugador, nombre, equipo, idJugador from Jugador";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                JAGSport.FormVariable.PlayerStats.idPJ = id;
                player.ShowDialog();
            }
            



        }
    }
}
