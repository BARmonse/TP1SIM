using NumerosAleatorios.Generadores;
using NumerosAleatorios.GeneradorIntervalos;
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
    public partial class PantallaChiCuadrado : Form
    {
        DataTable tablaPrueba;
        DataTable tablaAleatorios;
        Truncador truncador;

        int cantidad;
        int cantidadIntervalos;

        double[] inicioIntervalos;
        double[] finIntervalos;
        int[] frecuenciasObservadas;

        double[] jiCuadrado = { 0, 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9,
                                18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9,
                                30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1,
                                41.3, 42.6, 43.8};

        public PantallaChiCuadrado()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            tomarDatos();
            if (cantidad <= 0 || cantidadIntervalos <=0) { MessageBox.Show("El tamaño de la muestra debe ser mayor a 0..."); }
            tablaAleatorios.Clear();
            generarNumerosAleatorios();
            
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
            IGenerador generador = new GeneradorLenguaje(tablaAleatorios, truncador);
            generador.generarSerie(cantidad,contador);

            grdAleatorios.DataSource = tablaAleatorios;
            frecuenciasObservadas = contador.obtenerFrecuencias();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            construirTabla();
            evaluarHipotesis();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {

        }

        private void PantallaChiCuadrado_Load(object sender, EventArgs e)
        {
            truncador = new Truncador(4);
            tablaAleatorios = new DataTable();
            tablaPrueba = new DataTable();

            tablaAleatorios.Columns.Add("Iteración");
            tablaAleatorios.Columns.Add("Número");

            tablaPrueba.Columns.Add("Intervalo");
            tablaPrueba.Columns.Add("FO");
            tablaPrueba.Columns.Add("FE");
            tablaPrueba.Columns.Add("C");
            tablaPrueba.Columns.Add("C (ac)");
        }

        private void tomarDatos()
        {
            cantidad = int.Parse(cant.Text);
            cantidadIntervalos = int.Parse(cantIntervalos.Text);
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
                lblResultado.Text = "Se rechaza la hipótesis nula con un nivel de confianza de 95%";
            }
        }
    }
}
