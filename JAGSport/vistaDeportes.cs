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
    public partial class vistaDeportes : Form
    {
        public vistaDeportes()
        {
            InitializeComponent();
        }

        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");
        Deportes deportes = new Deportes();

        private void vistaDeportes_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select * from Deporte";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idT = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nameT = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if(idT == "" || nameT == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JAGSport.FormVariable.Deportes.name = nameT;
                JAGSport.FormVariable.Deportes.id = idT;

                deportes.ShowDialog();
            }

            
        }
    }
}
