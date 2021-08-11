using NumerosAleatorios.Soporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios.Generadores
{
    class GeneradorCongruencialMixto : IGenerador
    {
        private Truncador truncador;
        private DataTable dataTable;
        private DataRow dataRow;

        private long entradaAnterior;
        private long entradaActual;
        private double aleatorioActual;

        private double aleatorio;

        // parametros
        private int c;
        private int a;
        private long m;

        public GeneradorCongruencialMixto(DataTable tabla, Truncador truncador, long semilla, int c, int a, long m)
        {
            this.entradaAnterior = semilla;
            this.truncador = truncador;
            this.a = a;
            this.c = c;
            this.m = m;
            this.dataTable = tabla;
        }
        public DataTable generarSerie(int cantidadAleatorios)
        {
            dataTable.Rows.Clear();

            for (int i = 0; i < cantidadAleatorios; i++)
            {
                aleatorio = siguienteAleatorio();
                dataRow = dataTable.NewRow();
                dataRow[0] = i + 1;
                dataRow[1] = aleatorio;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        public double siguienteAleatorio()
        {
            entradaActual = ((a * entradaAnterior) + c) % (m);
            aleatorioActual = (double)entradaActual / (m); // (m-1) para incluir el 1 
            entradaAnterior = entradaActual;
            return truncador.truncar(aleatorioActual);
        }
    }
}
