/*
----------------------------
VIDEO 6: SINTAXIS BASICA V
----------------------------
-> Conversion de texto a numero
*/

using System;

namespace _7._SINTAXIS_BASICA_V
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------
            // Ingresar datos al sistema
            // --------------------------
            Console.WriteLine("Ingreso de variables en el sistema");

            System.Console.WriteLine("Ingresar el primer numero:");
            int num_1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresar el segundo numero:");
            int num_2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"El resultado es: {num_1+num_2}");
        }
    }
}
