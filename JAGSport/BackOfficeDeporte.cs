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
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            deporte = new Deporte(deporteTxt.Text);

            if(!deporte.autenticacionDeporte())
            {
                deporte.agregarDeporte();
                lista1.Items.Add(deporte.mostrarDeporte());

            }
            else
            {
                MessageBox.Show("Ya existe un Deporte con ese Nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deporteTxt.Text = "";
            }
            
            
        }
    }
}
