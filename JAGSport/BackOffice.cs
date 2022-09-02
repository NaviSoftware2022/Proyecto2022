﻿using System;
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
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        Usuario user = new Usuario();
        BackOfficeDeporte deporte = new BackOfficeDeporte();

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            user = new Usuario("a", "b");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = new Usuario(correoTxt1.Text, passwordTxt1.Text);
            if(!user.autenticacionUser())
            {
                user.agregarx();
                user.agregary();
                MessageBox.Show("Accion Realizada con Exito", "Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTxt1.Text = "";
                passwordTxt1.Text = "";
            }
            else
            {
                MessageBox.Show("Ya existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoTxt1.Text = "";
                passwordTxt1.Text = "";
            }

        }

        private void btnMiembro1_Click(object sender, EventArgs e)
        {
            UsuarioVIP userVip = new UsuarioVIP(correoTxt1.Text, passwordTxt1.Text, 1);
            user = new Usuario(correoTxt1.Text, passwordTxt1.Text);
            if(!user.autenticacionUserNormal())
            {
                user.agregarx();
                userVip.agregar();
                MessageBox.Show("Accion Realizada con Exito", "Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTxt1.Text = "";
                passwordTxt1.Text = "";
            }
            else
            {
                MessageBox.Show("Ya existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoTxt1.Text = "";
                passwordTxt1.Text = "";
            }

        }

        private void btnAdmin1_Click(object sender, EventArgs e)
        {
            UsuarioAdmin userAdmin = new UsuarioAdmin(correoTxt1.Text, passwordTxt1.Text,"1");
            user = new Usuario(correoTxt1.Text, passwordTxt1.Text);
            if(!user.autenticacionUserNormal())
            {
                user.agregarx();
                userAdmin.agregar();
                MessageBox.Show("Accion Realizada con Exito", "Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTxt1.Text = "";
                passwordTxt1.Text = "";
            }
            else
            {
                MessageBox.Show("Ya existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoTxt1.Text = "";
                passwordTxt1.Text = "";
            }
        }






        private void btnNor2_Click(object sender, EventArgs e)
        {
            user = new Usuario(correoTxt2.Text, passwordTxt2.Text);
            if(user.autenticacionUser())
            {
                user.eliminary();
                user.eliminarx();
                MessageBox.Show("Accion Realizada con Exito", "Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTxt2.Text = "";
                passwordTxt2.Text = "";
            }
            else
            {
                MessageBox.Show("No existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoTxt2.Text = "";
                passwordTxt2.Text = "";
            }
        }

        private void btnMiembro2_Click(object sender, EventArgs e)
        {
            UsuarioVIP userVip = new UsuarioVIP(correoTxt2.Text, passwordTxt2.Text, 1);
            user = new Usuario(correoTxt2.Text, passwordTxt2.Text);
            if(user.autenticacionUserNormal())
            {
                userVip.eliminar();
                user.eliminarx();
                MessageBox.Show("Accion Realizada con Exito", "Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTxt2.Text = "";
                passwordTxt2.Text = "";
            }
            else
            {
                MessageBox.Show("No existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoTxt2.Text = "";
                passwordTxt2.Text = "";
            }

        }

        private void btnAdmin2_Click(object sender, EventArgs e)
        {
            UsuarioAdmin userAdmin = new UsuarioAdmin(correoTxt2.Text, passwordTxt2.Text, "1");
            user = new Usuario(correoTxt2.Text, passwordTxt2.Text);
            if (user.autenticacionUserNormal())
            {
                userAdmin.eliminar();
                user.eliminarx();
                MessageBox.Show("Accion Realizada con Exito", "Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correoTxt2.Text = "";
                passwordTxt2.Text = "";
            }
            else
            {
                MessageBox.Show("No existe esa Cuenta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correoTxt2.Text = "";
                passwordTxt2.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            deporte.ShowDialog();
        }
    }
}