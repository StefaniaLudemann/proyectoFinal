using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Contadora
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario= txtUsuario.Text;
            string contrasena= txtContrasena.Text;
            frmMenu frmMenu1 = new frmMenu(); //instancia de frmMenu.


            if (usuario==string.Empty || contrasena==string.Empty)
            {
                MessageBox.Show("Por favor ingrese alguno de los campos");

            }
            else if(usuario != "stefania" || contrasena != "hola12")
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Intente nuevamente");

            }
            else if(usuario == "stefania" && contrasena == "hola12")
            {
                this.Hide();
                frmMenu1.Show(); 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklblContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Intente en 2 minutos", "Link Invalido");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ipracticando github");
        }
    }
}
