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
using static JAGSport.Logica.Publicidad1;

namespace JAGSport.FormVariable
{
    public partial class eventosProximos : Form
    {
        public eventosProximos()
        {
            InitializeComponent();
        }

        public static string idEvento;
        public static string correo;
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

        private void eventosProximos_Load(object sender, EventArgs e)
        {
            datos.Open();
            MySqlCommand comando = new MySqlCommand("select fecha ,hora, nombreDeporte, equipo1, equipo2 from Eventofijado where idEvento = @id", datos);
            comando.Parameters.AddWithValue("@id", idEvento);
            MySqlDataReader lector = comando.ExecuteReader();

            string team1V = "", team2V = "";


            if (lector.Read())
            {
                fechaEve.Text = Convert.ToString(lector["fecha"]);
                horaEve.Text = Convert.ToString(lector["hora"]);
                deporteEve.Text = Convert.ToString(lector["nombreDeporte"]);
                team1.Text = Convert.ToString(lector["equipo1"]);
                team2.Text = Convert.ToString(lector["equipo2"]);
                team1V = Convert.ToString(lector["equipo1"]);
                team2V = Convert.ToString(lector["equipo2"]);
            }

            datos.Close();

            List<string> list = new List<string>();
            ParticipaFijado participa = new ParticipaFijado(0, Convert.ToInt32(idEvento), 0);
            list = participa.mostrarEquipos();
            string idTeam1 = list[0];
            string idTeam2 = list[1];

            DataTable origendatos;
            MySqlCommand cmdSelect = new MySqlCommand("select nombre from jugador a, integra b where idEquipo = @t1", datos);
            cmdSelect.Parameters.AddWithValue("@t1", idTeam1);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            jugador1.DataSource = origendatos;

            DataTable origendatos2;
            MySqlCommand cmdSelect2 = new MySqlCommand("select nombre from jugador a, integra b where idEquipo = @t1", datos);
            cmdSelect2.Parameters.AddWithValue("@t1", idTeam2);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmdSelect);
            origendatos2 = new DataTable();
            adapter2.Fill(origendatos2);
            jugador2.DataSource = origendatos2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(correo == null)
            {
                MessageBox.Show("Debe iniciar sesion!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                UsuarioVIP user = new UsuarioVIP(correo, "", 1);
                suscribe sub = new suscribe(correo, idEvento);

                if(user.autenticacion())
                {
                    if (sub.autenticacionSub())
                    {
                        MessageBox.Show("Ya estas subscripto a este evento!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sub.agregarSub();
                        MessageBox.Show("Subscripcion completada con exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("Debes ser un usuario VIP para subscribirte!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
