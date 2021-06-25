/*
---------------------
VIDEO 10: METODOS II
--------------------
*/
using System;

namespace _10._METODOS_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamado al procedimiento
            mensajePantalla();
            Console.WriteLine("");

            // Llamado al procedimiento
            sumaNumeros(2,3);
        } 

        // ----------------------------------
        // Procedimiento: No retorna valores
        // ----------------------------------
        static void mensajePantalla()
        {
            System.Console.WriteLine("Llamado a procedimiento");
        }
         static void sumaNumeros(int num1, int num2)
        {
            int resultado = num1 + num2;
            System.Console.WriteLine($"La suma de los numeros es {resultado}");
        }
    }
}
