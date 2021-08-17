using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios.Soporte
{
    class FrecuenciaEsperadaUniforme
    {
        private int[] frecuenciaEsperada;

        private int cantidadNumeros;
        private int cantidadIntervalos;

        private double[] inicioIntervalos;
        private double[] finIntervalos;

        public FrecuenciaEsperadaUniforme(int cantidadNumeros, double[] inicioIntervalos, double[] finIntervalos)
        {
            this.cantidadNumeros = cantidadNumeros;
            this.cantidadIntervalos = inicioIntervalos.Length;
            this.frecuenciaEsperada = new int[cantidadIntervalos];
            this.inicioIntervalos = inicioIntervalos;
            this.finIntervalos = finIntervalos;
        }

        public int[] obtenerFrecuencias() {
            for (int i = 0; i < frecuenciaEsperada.Length; i++)
            {
                frecuenciaEsperada[i] = cantidadNumeros / cantidadIntervalos;
            }
            return frecuenciaEsperada; 
        }

    }
}
