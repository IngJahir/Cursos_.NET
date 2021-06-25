/*
---------------------
VIDEO 11: METODOS III
---------------------
*/
using System;

namespace _11._METODOS_III
{
    class Program
    {
        static void Main(string[] args)
        {
            // Suma con funcion
            // ----------------
            Console.WriteLine("SUMA CON FUNCION");
            var suma = sumaNumeros(2,3);
            Console.WriteLine($"La suma de los numeros es {suma}");
            Console.WriteLine("");

            Console.WriteLine("DIVIDE CON FUNCION");
            var division = divideNumeros(2,3);
            Console.WriteLine($"La division de los numeros es {division}");
            Console.Write("");
        }

        // ---------------------------
        // Funciones: Retorna valores
        // ---------------------------
        static int sumaNumeros(int num1, int num2)
        {
            int suma = num1 + num2;
            return suma;
        }

        // Funciones con UNA SOLA LINEA DE CODIGO
        static int restaNumeros(int num1, int num2) => num1-num2;
        static int multiplicacionNumeros(int num1, int num2)=> num1*num2;
        static double divideNumeros(double num1, double num2) => num1 / num2;
    }
}
