using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JAGSport.FormLogin;
using MySql.Data.MySqlClient;

namespace JAGSport
{
    public partial class HomeVIP : Form
    {
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root;");

        Activar activar = new Activar();
        FormLogin login = new FormLogin();
        ArrayList a = new ArrayList();
        
        Home home = new Home();

        public static string datosLog;
        public static string datosAct;



        public HomeVIP()
        {
            InitializeComponent();
        }

      

        private void HomeVIP_Load(object sender, EventArgs e)
        {
            
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Cerrar Sesion??", "Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                home.ShowDialog();
            }
        }

        private void HomeVIP_Load_1(object sender, EventArgs e)
        { }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select distinct ev.idEvento, fecha, hora, minuto, nombreEquipo, p.resultado from participa p, equipo eq, evento ev where eq.idEquipo = p.idEquipo and ev.idEvento = p.idEvento";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }
    }
}
