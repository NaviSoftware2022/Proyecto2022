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
    public partial class eventosVIVO : Form
    {
        public eventosVIVO()
        {
            InitializeComponent();
        }

        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");
        public static string idEvento;
        string team1V = "", team2V = "", fechaEve = "", horaEve = "", deporteEve = "";

        private void listaLugarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            paisComboBox.ResetText();
            paisComboBox.Items.Clear();

            paisComboBox.Enabled = true;

            string nombreLugar = listaLugarBox.SelectedItem.ToString();
            List<string> list = new List<string>();

            Ubicacion place = new Ubicacion(nombreLugar, "");
            list = place.mostrarPais();

            foreach (string a in list)
            {
                paisComboBox.Items.Add(a);
            }
        }

        private void eventosVIVO_Load(object sender, EventArgs e)
        {
            resultado1.Value = 0;
            resultado2.Value = 0;

            datos.Open();
            MySqlCommand comando = new MySqlCommand("select fecha ,hora, nombreDeporte, equipo1, equipo2 from Eventofijado where idEvento = @id", datos);
            comando.Parameters.AddWithValue("@id", idEvento);
            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                fechaEve = Convert.ToString(lector["fecha"]);
                horaEve = Convert.ToString(lector["hora"]);
                deporteEve = Convert.ToString(lector["nombreDeporte"]);
                team1.Text = Convert.ToString(lector["equipo1"]);
                team2.Text = Convert.ToString(lector["equipo2"]);
                team1V = Convert.ToString(lector["equipo1"]);
                team2V = Convert.ToString(lector["equipo2"]);
            }
            datos.Close();

            listaLugarBox.ResetText();
            listaLugarBox.Items.Clear();
            paisComboBox.ResetText();
            paisComboBox.Items.Clear();
            List<string> listaLugar = new List<string>();
            Ubicacion place = new Ubicacion();
            listaLugar = place.mostrarNombreLugar();

            foreach (string a in listaLugar)
            {
                listaLugarBox.Items.Add(a);
            }

            DataTable origendatos;
            MySqlCommand cmdSelect = new MySqlCommand("select * from eventofijado where idEvento = @id;", datos);
            cmdSelect.Parameters.AddWithValue("@id", idEvento);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ParticipaFijado participaP = new ParticipaFijado(0, Convert.ToInt32(idEvento), 0);
            int r1 = Convert.ToInt32(resultado1.Value);
            int r2 = Convert.ToInt32(resultado2.Value);

            List<string> list = new List<string>();

            list = participaP.mostrarEquipos();
            int idTeam1 = Convert.ToInt32(list[0]);
            int idTeam2 = Convert.ToInt32(list[1]);

            Deporte sport = new Deporte(deporteEve);
            int idSport = Convert.ToInt32(sport.ID());


            // Eliminar Relacion Evento - Correo
            suscribe sub = new suscribe("", idEvento);
            sub.eliminarsub();

            // Eliminar Relacio Evento - Equipo - Deporte        
            participaP.eliminarParticipa();

            // Eliminar Evento
            EventoProximo eventoP = new EventoProximo();
            eventoP.eliminarEvento(Convert.ToInt32(idEvento));

            // Ingresar Evento
            Evento evento = new Evento(Convert.ToDateTime(fechaEve), Convert.ToDateTime(horaEve), deporteEve, r1, r2, team1V, team2V);
            evento.agregarEvento();

            int idEventoNew = Convert.ToInt32(evento.ID());

            // Ingresar Participa
            Participa participa1 = new Participa(idTeam1, Convert.ToInt32(idEventoNew), idSport);
            Participa participa2 = new Participa(idTeam2, Convert.ToInt32(idEventoNew), idSport);
            participa1.agregarParticipa();
            participa2.agregarParticipa();

            Ubicacion place = new Ubicacion(listaLugarBox.SelectedItem.ToString(), paisComboBox.SelectedItem.ToString());
            int idLugar = place.ID();

            Pasa pasa = new Pasa(idLugar.ToString(), idEventoNew.ToString());
            pasa.agregarPasa();

            MessageBox.Show("Accion completada con Exito!!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
    }
}
