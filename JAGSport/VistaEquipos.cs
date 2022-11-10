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
    public partial class VistaEquipos : Form
    {
        public VistaEquipos()
        {
            InitializeComponent();
        }

        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root;");
        Teams team = new Teams();

        private void VistaEquipos_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select idEquipo, nombreEquipo  from Equipo";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idT = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nameT = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            JAGSport.FormVariable.Teams.name = nameT;
            JAGSport.FormVariable.Teams.id = idT;

            team.ShowDialog();
        }
    }
}
