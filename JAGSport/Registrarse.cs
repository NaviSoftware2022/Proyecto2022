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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botonCorreo_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario(correoBox.Text, contraseniaBox.Text);
            UsuarioVIP userV = new UsuarioVIP(correoBox.Text, contraseniaBox.Text, 1);
            UsuarioAdmin userA = new UsuarioAdmin(correoBox.Text, contraseniaBox.Text, "1");
            if (correoBox.Text.Trim() == "" || correoBox.Text == "" || contraseniaBox.Text.Trim() == "" || contraseniaBox.Text == "")
            {
                MessageBox.Show("Rellene campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user.autenticacion())
                {
       
                    MessageBox.Show("ya existe una Cuenta con ese Correo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correoBox.Text = "";
                    contraseniaBox.Text = "";
                } 
                else
                {
                    user.agregarx();
                    user.agregary();
                    MessageBox.Show("Cuenta Registrada con Exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    correoBox.Text = "";
                    contraseniaBox.Text = "";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
