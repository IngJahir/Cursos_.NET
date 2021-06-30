/*
-------------------------------------
VIDEO 28: POO II: Clases e instancias
-------------------------------------
*/
using System;

namespace _28._POO_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion e instantacion del objeto circulo
            Circulo miCirculo_1 = new Circulo();
            Circulo miCirculo_2 = new Circulo();

            Console.WriteLine($"El area del circulo_1 es {miCirculo_1.calculoArea(5)}");
            Console.WriteLine($"El area del circulo_2 es {miCirculo_2.calculoArea(9)}");
        }
    }

    // Nuevas clases
    // -------------
    class Circulo
    {
        // Propiedades de la clase o campo de clase
        const double PI = 3.1416;

        // Comportamientos.
        public double calculoArea(int radio) => PI * Math.Pow(radio, 2);
    }
}
