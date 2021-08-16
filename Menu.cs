using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosAleatorios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMixtoMultiplicativo_Click(object sender, EventArgs e)
        {
            PantallaGeneradores pantallaMixtoMultiplicativo = new PantallaGeneradores();
            pantallaMixtoMultiplicativo.Show();
        }

        private void btnPruebaChiLenguaje_Click(object sender, EventArgs e)
        {
            PantallaChiCuadrado pantallaChiCuadrado = new PantallaChiCuadrado();
            pantallaChiCuadrado.Show();
        }

        private void btnPruebaCongruencialMixto_Click(object sender, EventArgs e)
        {
            PantallaPruebaCongruencialMixto pantallaPruebaCongruencialMixto = new PantallaPruebaCongruencialMixto();
            pantallaPruebaCongruencialMixto.Show();
        }
    }
}
