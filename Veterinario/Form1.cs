using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moduloVeterinario_Click(object sender, EventArgs e)
        {
            Frnve frn = new Frnve();
            frn.Show();
        }

        private void moduloCliente_Click(object sender, EventArgs e)
        {
            Frncl frn = new Frncl();
            frn.Show();
        }

        private void moduloMascotas_Click(object sender, EventArgs e)
        {
            Frnma frn = new Frnma();
            frn.Show();
        }

        private void moduloDesparasitacion_Click(object sender, EventArgs e)
        {
            Frnde frn = new Frnde();
            frn.Show();
        }

        private void moduloVacuna_Click(object sender, EventArgs e)
        {
            Frnva frn = new Frnva();
            frn.Show();
        }
    }
}
