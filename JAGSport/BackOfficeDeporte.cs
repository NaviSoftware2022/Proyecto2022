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
    public partial class BackOfficeDeporte : Form
    {

        Deporte deporte = new Deporte();
        Evento evento = new Evento();
        Equipo equipo = new Equipo();
        List<int> deportes = new List<int>();
        Participa participa = new Participa();

        public BackOfficeDeporte()
        {
            InitializeComponent();
        }

        int puntuacion = 0;
        int contador = 0;
        int id = 0;
        

        public int Puntuacion ()
        {
            return puntuacion;
        }




        private void BackOfficeDeporte_Load(object sender, EventArgs e)
        {

            int id = 0;

            try
            {

                for (int i = 0; i < deporte.mostrarDeporte().Count; i++)
                {
                    lista1.Items.Add(deporte.mostrarDeporte()[i]);
                }

                for (int i = 0; i < equipo.mostrarEquipo().Count; i++)
                {
                    lista2.Items.Add(equipo.mostrarEquipo()[i]);
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }

        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {

            try
            {
                deporte = new Deporte(deporteTxt.Text);

                if (!deporte.autenticacionDeporte() && !(deporteTxt.Text == ""))
                {
                    deporte.agregarDeporte();
                    lista1.Items.Clear();
                    for (int i = 0; i < deporte.mostrarDeporte().Count; i++)
                    {
                        lista1.Items.Add(deporte.mostrarDeporte()[i]);
                    }
                    deporteTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error Al ingresar el Deporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    deporteTxt.Text = "";
                }
            } catch
            {
                MessageBox.Show("ERROR");
            }

         


        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {
            try
            {
                deporte = new Deporte(deporteTxt.Text);

                if (deporte.autenticacionDeporte() && (deporteTxt.Text != ""))
                {
                    deporte.eliminarDeporte();
                    deporteTxt.Text = "";
                    lista1.Items.Clear();
                    for (int i = 0; i < deporte.mostrarDeporte().Count; i++)
                    {
                        lista1.Items.Add(deporte.mostrarDeporte()[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Error Al ingresar el Deporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    deporteTxt.Text = "";
                }
            }
            catch
            {

            }

          


        }




        private void button2_Click(object sender, EventArgs e)
        {
            equipo = new Equipo(EquipoTxt.Text);
            int a = Convert.ToInt32(idDeporteTxt.Text);

            try
            {
                if (!(equipo.autenticacionEquipo(a)) && EquipoTxt.Text != "" && idDeporteTxt.Text != "")
                {



                    equipo.agregarEquipo(a);
                    lista2.Items.Clear();
                    for (int i = 0; i < equipo.mostrarEquipo().Count; i++)
                    {
                        lista2.Items.Add(equipo.mostrarEquipo()[i]);
                    }
                    EquipoTxt.Text = "";
                    idDeporteTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error Al ingresar el Equipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EquipoTxt.Text = "";
                    idDeporteTxt.Text = "";
                }
            } catch
            {
                MessageBox.Show("ERROR");
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                equipo = new Equipo(EquipoTxt.Text);
                int a = Convert.ToInt32(idDeporteTxt.Text);

                if (equipo.autenticacionEquipo(a) && EquipoTxt.Text != "" && idDeporteTxt.Text != "")
                {



                    equipo.eliminarEquipo(a);
                    lista2.Items.Clear();
                    for (int i = 0; i < equipo.mostrarEquipo().Count; i++)
                    {
                        lista2.Items.Add(equipo.mostrarEquipo()[i]);
                    }
                    EquipoTxt.Text = "";
                    idDeporteTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error Al ingresar el Equipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EquipoTxt.Text = "";
                    idDeporteTxt.Text = "";
                }
            } catch
            {
                MessageBox.Show("ERROR");
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox2.Text);
            idEvento.Text = textBox2.Text;


            evento = new Evento(id, eventoBoxD.Text, horaBoxE.Text, MinutoTxt.Text, Puntuacion());

            try
            {
                if (puntuacion != 0 && eventoBoxD.Text != "" && horaBoxE.Text != "" && MinutoTxt.Text != "" && textBox2.Text != "")
                {
                    evento.agregarEvento();
                    contador++;


                    label8.Visible = true;
                    listaTxtComp.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    textBox1.Visible = true;
            
                    btnEnviar.Visible = true;
                    PuntosText.Visible = true;
                    enviarTxt.Visible = true;
                    label20.Visible = true;
                    idEvento.Visible = true;
                    label19.Visible = true;
                  

                    MessageBox.Show("Evento Creado Exitosamente, ahora ingrese los equipos que compiten", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("ERROR");
            }

            
        }

        private void puntosBtn_Click(object sender, EventArgs e)
        {
            puntuacion = 1;
            labelPuntuacion.Text = "Puntos";
        }

        private void distanciaBtn_Click(object sender, EventArgs e)
        {
            puntuacion = 2;
            labelPuntuacion.Text = "Distancia";
        }

        private void tiempoBtn_Click(object sender, EventArgs e)
        {
            puntuacion = 3;
            labelPuntuacion.Text = "Tiempo";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void enviarTxt_Click(object sender, EventArgs e)
        {

            int evento = Convert.ToInt32(idEvento.Text);
            int resultado = Convert.ToInt32(PuntosText.Text);
            int a = Convert.ToInt32(textBox1.Text);



            try
            {
                if (equipo.autenticacionEquipoID(a))
                {
                    listaTxtComp.Items.Add(a + " - " + resultado);

                    participa = new Participa(a, evento, resultado);


                    participa.agregarParticipa();


                    label12.Visible = true;
                    if (puntuacion == 1) { btnPuntos.Visible = true; } else if (puntuacion == 2) { btnDistancia.Visible = true; } else { btnTiempo.Visible = true; }

                    MessageBox.Show("Datos de Evento Ingresados Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";
                    eventoBoxD.Text = "";
                    horaBoxE.Text = "";
                    MinutoTxt.Text = "";
                    labelPuntuacion.Text = "Tipo de Puntuacion";
                    listaTxtComp.Items.Clear();
                    textBox1.Text = "";
                    PuntosText.Text = "";
                    idEvento.Text = "";



                }
                else
                {
                    MessageBox.Show("Verifique los datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch
            {
                MessageBox.Show("ERROR");
            }
           

         
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Eliminar.Text != "")
                {
                    evento.eliminarEventox(Eliminar.Text);
                   

                    MessageBox.Show("Evento ELiminado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
