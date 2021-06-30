/*
-----------------------------------------
VIDEO 33: POO VII: Llamadas y clase Math
-----------------------------------------
->
*/
using System;

namespace _33._POO_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            Punto oOrigen = new Punto();
            Punto oDestino = new Punto(19, 20);
            double distancia = oOrigen.distancia(oDestino);
            System.Console.WriteLine($"La distancia entre los puntos es de {distancia}");
        }
    }
}
