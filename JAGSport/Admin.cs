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
        eventosVIVO vivo = new eventosVIVO();
        UbicacionForm place = new UbicacionForm();

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
            gestor.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evento.ShowDialog();
        }

        private void resultadoEvento_Tick(object sender, EventArgs e)
        {
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            List<DateTime> hora = new List<DateTime>();
            List<DateTime> fecha = new List<DateTime>();
            List<string> idEvento = new List<string>();

            DateTime dia = DateTime.Now.Date;
            DateTime fechaNow = DateTime.Now;

            EventoProximo evento = new EventoProximo();
            fecha = evento.obtenerFecha();
            hora = evento.obtenerHora();
            idEvento = evento.obtenerID();

            for (int i = 0; i < fecha.Count; i++)
            {
                if (fecha[i] <= fechaNow && hora[i] <= fechaNow)
                {
                    MessageBox.Show("Hay un evento que necesita que se ingrese un resultado!!!", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    JAGSport.eventosVIVO.idEvento = idEvento[i];
                    vivo.ShowDialog();
                    break;
                }
            }
        }

        private void ubicacion_Click(object sender, EventArgs e)
        {
            place.ShowDialog();
        }
    }
}
