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
    public partial class place : Form
    {
        public place()
        {
            InitializeComponent();
        }
        public static string id;
        public static string name;
        public static string pais;
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");


        private void place_Load(object sender, EventArgs e)
        {
            placetxt.Text = name;
            paistxt.Text = pais;

            DataTable origendatos;
            MySqlCommand cmdSelect = new MySqlCommand("select a.* from evento a, lugar b, pasa c where a.idEvento=c.idEvento and c.idLugar=b.idLugar and b.idLugar = @id;", datos);
            cmdSelect.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
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
