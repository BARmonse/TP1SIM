using System.Data;

namespace NumerosAleatorios.Generadores
{
    internal interface IGenerador
    {
        double siguienteAleatorio();
        DataTable generarSerie(int cantidadAleatorios);
    }
}