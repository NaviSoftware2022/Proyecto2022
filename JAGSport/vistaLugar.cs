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
    public partial class vistaLugar : Form
    {
        public vistaLugar()
        {
            InitializeComponent();
        }
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void place_Click(object sender, EventArgs e)
        {

        }

        private void pais_Click(object sender, EventArgs e)
        {

        }

        private void vistaLugar_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select * from Lugar";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string pais = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (id == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JAGSport.FormVariable.place.name = name;
                JAGSport.FormVariable.place.id = id;
                JAGSport.FormVariable.place.pais = pais;

                place lugar = new place();
                this.Hide();
                lugar.ShowDialog();
            }
        }
    }
}
