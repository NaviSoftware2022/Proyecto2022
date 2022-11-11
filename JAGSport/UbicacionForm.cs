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
    public partial class UbicacionForm : Form
    {
        public UbicacionForm()
        {
            InitializeComponent();
        }
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void button1_Click(object sender, EventArgs e)
        {
            if (namePlacetxt.Text != "" && paistxt.Text != "")
            {
                Ubicacion place = new Ubicacion(namePlacetxt.Text, paistxt.Text);
                if (!place.autenticacionLugar())
                {
                    place.agregarLugar();
                    namePlacetxt.Text = "";
                    paistxt.Text = "";
                    tabla();
                    MessageBox.Show("Accion Realizada con exito!!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe ese lugar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene campos!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void tabla()
        {
            DataTable origendatos;
            string query = "select * from Lugar;";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void UbicacionForm_Load(object sender, EventArgs e)
        {
            tabla();
            namePlacetxt.Text = "";
            paistxt.Text = "";
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
                List<string> list = new List<string>();
                Pasa pasa = new Pasa(id, "");
       
                list = pasa.obtenerIDEvento();
                Evento evento = new Evento();

                foreach (string x in list)
                {
                    evento.eliminarEventoy(x);
                }

                pasa.eliminarPasaLugar();

                foreach (string x in list)
                {
                    evento.eliminarEvento(Convert.ToInt32(x));
                }

                

                Ubicacion place = new Ubicacion();
                place.eliminarLugar(id);
                MessageBox.Show("Accion Realizada con exito!!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void paistxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
