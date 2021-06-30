/*
-----------------------------------------------
VIDEO 34: POO VIII: Variables y metodos estatic
-----------------------------------------------
-> int contador =7: En este caso, se crea una copia independiente de la variable contador en cada objeto
-> static int contador = 7 : La varible contador es compartida en todos las intancias de objetos. La clase en donde se declaro, sera la unica que puede variarla.
*/
using System;

namespace _34._POO_VIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otroPunto = new Punto();
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Numero de objetos creados; {Punto.ContadorDeObjeto()}");
        }
    }
}
