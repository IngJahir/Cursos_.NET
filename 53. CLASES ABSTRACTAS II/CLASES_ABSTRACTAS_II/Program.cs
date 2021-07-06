/*
------------------------------
VIDEO 53: CLASES ABSTRACTAS II:
------------------------------

*/
using CLASES_ABSTRACTAS_II.Clases;
using System;

namespace CLASES_ABSTRACTAS_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASES ABSTRACTAS");
            Lagartija oLagartija = new Lagartija("Juancho");
            oLagartija.respirar();
            oLagartija.getNombre();
            Console.WriteLine("");

            Humano oHumano = new Humano("Pepito");
            oHumano.respirar();
            oHumano.getNombre();
            Console.WriteLine("");
        }
    }
}
