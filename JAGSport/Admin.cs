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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        Equipos equipo = new Equipos();
        DeporteForm deporte = new DeporteForm();
        BackOffice usuarios = new BackOffice();
        Jugadores jugador = new Jugadores();
        Gestor gestor = new Gestor();
        eventoSelct evento = new eventoSelct();

        private void button5_Click(object sender, EventArgs e)
        {
            jugador.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equipo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuarios.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestor.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evento.ShowDialog();
        }
    }
}
