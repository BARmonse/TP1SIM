using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios.Soporte
{

    class ContadorFrecuenciaObservada
    {
        private int[] frecuenciaObservada;

        private int cantidadIntervalos;

        private double[] inicioIntervalos;
        private double[] finIntervalos;

        public ContadorFrecuenciaObservada(double[] inicioIntervalos, double[] finIntervalos)
        {
            this.cantidadIntervalos = inicioIntervalos.Length;
            this.frecuenciaObservada = new int[cantidadIntervalos];
            this.inicioIntervalos = inicioIntervalos;
            this.finIntervalos = finIntervalos;
        }
        public void contarNumero(double numero)
        {
            for (int i = 0; i < cantidadIntervalos; i++)
            {
                if (numero >= inicioIntervalos[i] && numero <= finIntervalos[i])
                {
                    frecuenciaObservada[i] += 1;
                }
            }
        }

        public void contarFrecuenciaSerie(DataTable numeros)
        {
            for (int i = 0; i < numeros.Rows.Count; i++)
            {
                double aleatorio = double.Parse(numeros.Rows[i][1].ToString());
                contarNumero(aleatorio);
            }
        }
        public int[] obtenerFrecuencias()
        {
            return frecuenciaObservada;
        }

    }
}
