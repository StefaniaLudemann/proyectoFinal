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
    public partial class frmEdificio : Form
    {
        public frmEdificio()
        {
            InitializeComponent();
        }

        //REVISAR: NO ES DEL TODO CORRECTO
        private void btnSalirEdificio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu1 = new frmMenu();
            frmMenu1.ShowDialog();
        }
    }
}
