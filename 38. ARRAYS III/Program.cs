/*
--------------------------------
VIDEO 38: ARRAYS III: Bucle for
-------------------------------
-> Recorrido y acceso de arrays
-> Sintaxis Bucle for: for(int i=o; i<=8; i++) { Codigo }
*/
using System;

namespace _38._ARRAYS_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS");
            Console.WriteLine("------");

            // Array implicito de caracteres y numeros
            // -----------------------------------------
            Console.WriteLine("Array implicito de caracteres y numeros");
            Console.WriteLine("");
            var datos = new[] { "Jahir", "Tautiva", "15" };
            var valores = new[] { 10, 20, 30, 45, 50.25 };

            // Impresion de datos para valores
            Console.WriteLine("Datos personales");
            for (var i = 0; i < datos.Length; i++)
            {
                if (i == 0)
                    Console.WriteLine($"Nombre: {datos[i]}");
                else if (i == 1)
                    Console.WriteLine($"Apellido: {datos[i]}");
                else
                    Console.WriteLine($"Edad: {datos[i]}");
            }

            // Impresion de numeros
            Console.WriteLine("");
            Console.WriteLine("Numeros");
            for (var i = 0; i < valores.Length; i++) { Console.WriteLine($"El valor[{i}] es: {valores[i]}"); }
            Console.WriteLine("");
        }
    }
}
