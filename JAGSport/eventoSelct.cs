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
    public partial class eventoSelct : Form
    {
        public eventoSelct()
        {
            InitializeComponent();
        }
        eventoPasadoBackOffice pasado = new eventoPasadoBackOffice();
        eventoProximoBackOffice futuro = new eventoProximoBackOffice();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            futuro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pasado.ShowDialog();
        }
    }
}
