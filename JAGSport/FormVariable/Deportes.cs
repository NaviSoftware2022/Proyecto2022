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

namespace JAGSport.FormVariable
{
    public partial class Deportes : Form
    {
        public Deportes()
        {
            InitializeComponent();
        }


        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");
        public static string name;
        public static string id;

        private void Deportes_Load(object sender, EventArgs e)
        {
            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            deportetxt.Text = name;

            //
            DataTable origendatos;
            MySqlCommand cmdSelect = new MySqlCommand("select a.idEquipo, nombreEquipo, zona from Equipo a, juega b where a.idEquipo = b.idEquipo and b.idDeporte = @id;", datos);
            cmdSelect.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            equiposGrid.DataSource = origendatos;

            //
            DataTable origendatos2;
            MySqlCommand cmdSelect2 = new MySqlCommand("select distinct a.idEvento, fecha, hora, equipo1, equipo2 from Evento a, participa b, Deporte c where a.idEvento = b.idEvento and b.idDeporte = c.idDeporte and b.idDeporte = @id;", datos);
            cmdSelect2.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmdSelect2);
            origendatos2 = new DataTable();
            adapter2.Fill(origendatos2);
            eventosGrid.DataSource = origendatos2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void equiposGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(equiposGrid.CurrentRow.Cells[0].Value.ToString());
            string name = Convert.ToString(equiposGrid.CurrentRow.Cells[1].Value.ToString());

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Teams equipo = new Teams();
                FormVariable.Teams.id = id;
                FormVariable.Teams.name = name;
                equipo.ShowDialog();
            }
        }

        private void eventosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(eventosGrid.CurrentRow.Cells[0].Value.ToString());


            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eventosPasados evento = new eventosPasados();
                FormVariable.eventosPasados.idEvento = id;
                evento.ShowDialog();
            }
        }
    }
}
