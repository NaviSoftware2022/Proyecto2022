using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static JAGSport.Logica;

namespace JAGSport
{
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }

        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root;");
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = abrir.FileName;
                pictureBox2.Image = new Bitmap(abrir.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {

                MessageBox.Show("Ingrese un Nombre a la Publicidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                File.Copy(txtRuta.Text, Path.Combine(@"C:\Users\marce\Desktop\Proyecto UTU\JAGSport\Publicidad\", Path.GetFileName(txtRuta.Text)), true);
                label2.Text = "La publicidad ha sido agregada";

                

                Publicidad1 publicidad = new Publicidad1(txtNombre.Text, txtRuta.Text);
                publicidad.agregarPublicidad1();
                MessageBox.Show("Exito", "Accion completada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Text = "";
                txtRuta.Text = "";


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Publicidad1 publicidad = new Publicidad1(txtNombre.Text, txtRuta.Text);
            publicidad.eliminarPublicidad1();


            MessageBox.Show("Exito", "Accion completada con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

            txtNombre.Text = "";
            txtRuta.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select * from publicidad1;";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }
    }
}
