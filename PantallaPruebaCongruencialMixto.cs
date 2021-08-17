using NumerosAleatorios.Generadores;
using NumerosAleatorios.GeneradorIntervalos;
using NumerosAleatorios.Graficador;
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

namespace NumerosAleatorios
{
    public partial class PantallaPruebaCongruencialMixto : Form
    {
        long semilla;
        int k;
        int c;
        int a;
        int g;
        int m;

        int cantidad;
        int cantidadIntervalos;
        int indice;

        double[] inicioIntervalos;
        double[] finIntervalos;
        int[] frecuenciasObservadas;
        int[] frecuenciasEsperadas;

        double[] jiCuadrado = { 0, 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9,
                                18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9,
                                30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1,
                                41.3, 42.6, 43.8};

        Truncador truncador;
        DataTable tablaAleatorios;
        DataTable tablaPrueba;
        public PantallaPruebaCongruencialMixto()
        {
            InitializeComponent();
        }

        private void PantallaPruebaCongruencialMixto_Load(object sender, EventArgs e)
        {
            grdAleatorios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            truncador = new Truncador(4);

            tablaAleatorios = new DataTable();
            tablaAleatorios.Columns.Add("Iteración");
            tablaAleatorios.Columns.Add("Número");

            tablaPrueba = new DataTable();
            tablaPrueba.Columns.Add("Intervalo");
            tablaPrueba.Columns.Add("FO");
            tablaPrueba.Columns.Add("FE");
            tablaPrueba.Columns.Add("C");
            tablaPrueba.Columns.Add("C (ac)");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            grdAleatorios.DataSource = null;
            grdAleatorios.Refresh();
            tablaAleatorios.Rows.Clear();
            tomarDatos();
            if (cantidad <= 0 || cantidadIntervalos <= 0 || semilla <=0 || k <= 0 || g <= 0|| a <=0 || c <=0 || m <= 0) 
            {
                MessageBox.Show("Datos inválidos");
            }
            else { generarNumerosAleatorios(); }
            

        }

        private void generarNumerosAleatorios()
        {
            inicioIntervalos = new double[cantidadIntervalos];
            finIntervalos = new double[cantidadIntervalos];
            GeneradorIntervalosUniforme intervalos = new GeneradorIntervalosUniforme(truncador);

            intervalos.generarIntervalos(cantidadIntervalos);
            inicioIntervalos = intervalos.obtenerInicioIntervalos();
            finIntervalos = intervalos.obtenerFinIntervalos();

            ContadorFrecuenciaObservada contador = new ContadorFrecuenciaObservada(inicioIntervalos, finIntervalos);
            IGenerador generador = new GeneradorCongruencialMixto(tablaAleatorios, truncador, semilla, c, a, m);
            generador.generarSerie(cantidad, contador);

            grdAleatorios.DataSource = tablaAleatorios;
            frecuenciasObservadas = contador.obtenerFrecuencias();

            FrecuenciaEsperadaUniforme fe = new FrecuenciaEsperadaUniforme(cantidad, inicioIntervalos, finIntervalos);
            frecuenciasEsperadas = fe.obtenerFrecuencias();
        }

        private void tomarDatos()
        {
            semilla = int.Parse(txtSemilla.Text);
            k = int.Parse(txtK.Text);
            g = int.Parse(txtG.Text);
            a = int.Parse(txtA.Text);
            c = int.Parse(txtC.Text);
            m = int.Parse(txtM.Text);
            cantidad = int.Parse(cant.Text);
            indice = cantidad - 1;
            cantidadIntervalos = int.Parse(cantIntervalos.Text);
        }

        private void actualizarK()
        {
            a = int.Parse(txtA.Text);
            k = (a - 1) / 4;
            txtK.Text = k.ToString();
        }

        private void actualizarA()
        {
            k = int.Parse(txtK.Text);
            a = 1 + 4 * k;
            txtA.Text = a.ToString();

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

        private void txtK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarA();
                actualizarK();
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

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            construirTabla();
            evaluarHipotesis();
        }

        private void construirTabla()
        {
            tablaPrueba.Clear();
            DataRow row;
            double frecuenciaEsperada = truncador.truncar((double)cantidad / (double)cantidadIntervalos);
            double estadisticoPrueba;
            double estadisticoPruebaAcumuladoAnterior = 0;

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                row = tablaPrueba.NewRow();
                row[0] = "[" + inicioIntervalos[i] + "-" + finIntervalos[i] + "]";
                row[1] = frecuenciasObservadas[i];
                row[2] = frecuenciaEsperada;
                estadisticoPrueba = (Math.Pow((frecuenciaEsperada - frecuenciasObservadas[i]), 2) / frecuenciaEsperada);
                row[3] = truncador.truncar(estadisticoPrueba);
                row[4] = truncador.truncar(estadisticoPruebaAcumuladoAnterior + estadisticoPrueba);
                estadisticoPruebaAcumuladoAnterior += estadisticoPrueba;
                tablaPrueba.Rows.Add(row);
            }
            grdPrueba.DataSource = tablaPrueba;
        }

        private void evaluarHipotesis()
        {
            int v = cantidadIntervalos - 1; // m=0 porque no hubo observacion
            txtGradosLibertad.Text = v.ToString();
            double probabilidad = jiCuadrado[v];
            txtProbabilidad.Text = probabilidad.ToString();
            if (double.Parse(tablaPrueba.Rows[cantidadIntervalos - 1][4].ToString()) <= probabilidad)
            {
                lblResultado.Text = "No se rechaza la hipotesis de distribucion uniforme con un nivel de confianza de 95%";
            }
            else
            {
                lblResultado.Text = "Se rechaza la hipótesis de distribución uniforme con un nivel de confianza de 95%";
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            
            GraficadorExcelObservado graficador = new GraficadorExcelObservado();
            graficador.frecuenciaObservada = frecuenciasObservadas;
            graficador.inicioIntervalos = this.inicioIntervalos;
            graficador.finIntervalos = this.finIntervalos;
            graficador.frecuenciaEsperada = frecuenciasEsperadas;
            graficador.Show();
        }
    }
}
