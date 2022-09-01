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
    public partial class Home : Form
    {

        FormLogin login = new FormLogin();
        Usuario user = new Usuario();
        Activar activar = new Activar();

        public static string datosLog;

        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Home_Load_1(object sender, EventArgs e)
        {
            btnCuenta.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
           
            if (login.resultado == 1)
            {

            
            btnSesion.Visible = false;
            btnCuenta.Visible = true;
            btnActivar.Visible = true;

            btnCuenta.Text = datosLog;
            }
            else if (login.resultado == 0)
            {
                MessageBox.Show("Ups algo salio mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActivar_Click(object sender, EventArgs e)
        {
            
            activar.ShowDialog();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Cerrar Sesion??", "Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnCuenta.Visible = false;
                btnSesion.Visible = true;
                btnActivar.Visible = false;
            }
        }
   
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
