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
    public partial class vistaEventos : Form
    {
        public vistaEventos()
        {
            InitializeComponent();
        }
        eventosPasados eventoP = new eventosPasados();
        eventosProximos eventoF = new eventosProximos();
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void vistaEventos_Load(object sender, EventArgs e)
        {
            //
            DataTable origendatos;
            string query = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Evento";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;

            //
            DataTable origendatos2;
            string query2 = "select idEvento, fecha, hora, equipo1, equipo2, nombreDeporte from Eventofijado";
            MySqlCommand cmdSelect2 = new MySqlCommand(string.Format(query2), datos);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmdSelect2);
            origendatos2 = new DataTable();
            adapter2.Fill(origendatos2);
            dataGridView2.DataSource = origendatos2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idEvento = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            if (idEvento == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JAGSport.FormVariable.eventosPasados.idEvento = idEvento;
                this.Hide();
                eventoP.ShowDialog();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idEvento = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);

            if (idEvento == "")
            {
                MessageBox.Show("Parece que hubo un problema intentalo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                JAGSport.FormVariable.eventosProximos.idEvento = idEvento;
                this.Hide();
                eventoF.ShowDialog();
             }
        }
    }
}
