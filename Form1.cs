using NumerosAleatorios.Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumerosAleatorios.Generadores;

namespace NumerosAleatorios
{
    public partial class Form1 : Form
    {
        int cantidad;
        int semilla;
        int k;
        int a;
        int g;
        int m;
        int c;
        int indice;

        DataTable dt;
        DataRow dr;
        Truncador truncador;
        IGenerador generador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grdResultados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            truncador = new Truncador(4);
            dt = new DataTable();
            dt.Columns.Add("Iteración");
            dt.Columns.Add("Número");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdResultados.DataSource = null;
            grdResultados.Refresh();
            dt.Rows.Clear();
            semilla = int.Parse(txtSemilla.Text);
            k = int.Parse(txtK.Text);
            g = int.Parse(txtG.Text);
            a = int.Parse(txtA.Text);
            m = int.Parse(txtM.Text);
            cantidad = int.Parse(txtCantidad.Text);
            indice = cantidad - 1;

            if (rbMixto.Checked)
            {
                if (txtC.Text == "") { return; }
                c = int.Parse(txtC.Text);
                congruencialMixto();
            }
            else { congruencialMultiplicativo(); }
        }

        private void congruencialMixto()
        {
            generador = new GeneradorCongruencialMixto(dt, truncador, semilla, c, a, m);
            generador.generarSerie(cantidad);
            grdResultados.DataSource = dt;
        }

        private void congruencialMultiplicativo()
        {
            generador = new GeneradorCongruencialMultiplicativo(dt, truncador, semilla, a, m);
            generador.generarSerie(cantidad);
            grdResultados.DataSource = dt;
        }

        private void txtK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarA();
                actualizarK();
            }
        }


        private void txtG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarM();
                actualizarG();
            }
        }

        private void txtM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarG();
                actualizarM();
            }
        }

        private void txtA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarK();
                actualizarA();
            }
        }

        private void actualizarK()
        {
            a = int.Parse(txtA.Text);
            if (rbMixto.Checked)
            {
                k = (a - 1) / 4;
                txtK.Text = k.ToString();
            }
            else
            {
                k = (a - 3) / 8;
                txtK.Text = k.ToString();
            }
        }

        private void actualizarA()
        {
            k = int.Parse(txtK.Text);
            if (rbMixto.Checked)
            {
                a = 1 + 4 * k;
                txtA.Text = a.ToString();
            }
            else
            {
                a = 3 + 8 * k;
                txtA.Text = a.ToString();
            }
        }

        private void actualizarG()
        {
            m = int.Parse(txtM.Text);
            g = (int)Math.Log2(m);
            txtG.Text = g.ToString();
        }
        
        private void actualizarM()
        {
            g = int.Parse(txtG.Text);
            m = (int)Math.Pow(2, g);

            txtM.Text = m.ToString();
        }

        private void limpiarCampos()
        {
            txtG.Text = "";
            txtK.Text = "";
            txtC.Text = "";
            txtA.Text = "";
            txtM.Text = "";
            txtSemilla.Text = "";
        }
        private void manejarSeleccion()
        {
            limpiarCampos();
            if (rbMixto.Checked)
            {
                txtC.Enabled = true;
                return;
            }
            if (rbMultiplicativo.Checked)
            {
                txtC.Enabled = false;
                return;
            }
        }

        private void rbMixto_CheckedChanged(object sender, EventArgs e)
        {
            manejarSeleccion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarFilas(20);
        }
        private void agregarFilas(int cantidad)
        {
            for (int i=0;i < cantidad; i++)
            {
                agregarFila(generador.siguienteAleatorio());
            }
        }
        private void agregarFila(double aleatorio)
        {
            ++indice;
            dr = dt.NewRow();
            dr[0] = indice + 1;
            dr[1] = aleatorio;
            dt.Rows.Add(dr);
            enfocarFila();
        }
        private void enfocarFila()
        {
            grdResultados.CurrentCell = grdResultados.Rows[indice].Cells[0];
        }
    }
}
