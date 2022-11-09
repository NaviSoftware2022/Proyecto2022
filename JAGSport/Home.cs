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
using MySql.Data.MySqlClient;
using JAGSport.FormVariable;
using System.Collections;

namespace JAGSport
{
    public partial class Home : Form
    {

        FormLogin login = new FormLogin();
        Usuario user = new Usuario();
        Activar activar = new Activar();
        VistaEquipos team = new VistaEquipos();
        vistaJugadores player = new vistaJugadores();
        eventosPasados eventoP = new eventosPasados();
        vistaEventos eventos = new vistaEventos();
        vistaDeportes deporte = new vistaDeportes();

        

        public static string datosLog;
        public static int membresia;
        MySqlConnection datos = new MySqlConnection("Server=127.0.0.1; Database=jags; Uid=root; password=root");

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
                membresia = 1;
                this.Hide();
                Home casa = new Home();
                casa.ShowDialog();                              
            }
            else if (login.resultado == 0)
            {
                MessageBox.Show("Ups algo salio mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(login.resultado == 4)
            {
                membresia = 2;
                this.Hide();
                Home casa = new Home();
                casa.ShowDialog();

            } else
            {
                
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {        
            activar.ShowDialog();

            if(activar.resultado == 1)
            {
                membresia = 2;
                this.Hide();
                Home casa = new Home();
                casa.ShowDialog();
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Cerrar Sesion??", "Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                membresia = 3;
                this.Hide();
               
                Home casa = new Home();
                casa.ShowDialog();
            }
        }
   
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            team.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            List<string> listaPubli = new List<string>();
            Publicidad1 publicidad = new Publicidad1();
            listaPubli = publicidad.mostrarPublicidad1();

            if(listaPubli.Count != 0) { 
                int largo = listaPubli.Count;
                int azar = random.Next(0, largo);

                pictureBox3.Image = Image.FromFile(listaPubli[azar]);
                pictureBox4.Image = Image.FromFile(listaPubli[azar]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            player.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DataTable origendatos;
            string query = "select * from evento;";
            MySqlCommand cmdSelect = new MySqlCommand(string.Format(query), datos);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect);
            origendatos = new DataTable();
            adapter.Fill(origendatos);
            dataGridView1.DataSource = origendatos;

            if(membresia == 1)
            {
                btnCuenta.Text = datosLog;
                btnSesion.Visible = false;
                btnCuenta.Visible = true;
                btnActivar.Visible = true;
            }

            else if(membresia == 2)
            {
                pictureBox3.Visible = false;
                btnActivar.Visible = false;
                btnSesion.Visible = false;
                btnCuenta.Visible = true;
                btnCuenta.Text = datosLog;
            } else if (membresia == 3)
            {
                btnCuenta.Visible = false;
                btnSesion.Visible = true;
                btnActivar.Visible = false;
            }
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
                eventoP.ShowDialog();
            }

            JAGSport.FormVariable.eventosPasados.idEvento = id;

          

            
            
        }
   

        private void label3_Click(object sender, EventArgs e)
        {
            deporte.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }

        private void timerCorreo_Tick(object sender, EventArgs e)
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
                DateTime horaEventoMenos= hora[i].AddMinutes(-30);
                if ((horaEventoMenos <= fechaNow) && (fechaNow <= hora[i]) && (fecha[i] == dia))
                {
                    List<string> listCorreo = new List<string>();
                    suscribe usuarios = new suscribe("", idEvento[i]);
                    listCorreo = usuarios.mostrarUsuarios();

                    if (listCorreo.Count > 0)
                    {
                        for (int z = 0; z < listCorreo.Count; z++)
                        {
                            datos.Open();
                            MySqlCommand comando = new MySqlCommand("select fecha ,hora, nombreDeporte, equipo1, equipo2 from Eventofijado where idEvento = @id", datos);
                            comando.Parameters.AddWithValue("@id", idEvento[i]);
                            MySqlDataReader lector = comando.ExecuteReader();

                            string deporteE = "", equipo1E = "", equipo2E = "";
                            DateTime fechaE = DateTime.Now;
                            DateTime horaE = DateTime.Now;

                            if (lector.Read())
                            {
                                string c = lector["hora"].ToString();
                                horaE = Convert.ToDateTime(c);
                                deporteE = Convert.ToString(lector["nombreDeporte"]);
                                equipo1E = Convert.ToString(lector["equipo1"]);
                                equipo2E = Convert.ToString(lector["equipo2"]);
                            }

                            datos.Close();

                            //

                            StringBuilder mensaje = new StringBuilder();
                            mensaje.Append("JAGSport - Notificacion de Evento");
                            string Error = "";
                            string a = correos.EnviarCorreo(mensaje, DateTime.Now, "navisoftwareClient@gmail.com", listCorreo[z], "correo de prueba", equipo1E, equipo2E, horaE, out Error);

                        }
                        usuarios.eliminarsub();
                    }

                }

            }

        }
     

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

           
        }
    }
}
