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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEdificio frmedificio = new frmEdificio();    
            frmedificio.ShowDialog();

        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEgreso frmegreso = new frmEgreso();
            frmegreso.ShowDialog();

        }
    }
}
