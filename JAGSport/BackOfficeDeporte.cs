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

        public BackOfficeDeporte()
        {
            InitializeComponent();
        }




        private void BackOfficeDeporte_Load(object sender, EventArgs e)
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

        private void btnDeporte_Click(object sender, EventArgs e)
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


        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
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




        private void button2_Click(object sender, EventArgs e)
        {
            equipo = new Equipo(EquipoTxt.Text);
            int a = Convert.ToInt32(idDeporteTxt.Text);

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
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
