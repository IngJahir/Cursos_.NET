/*
------------------------------
VIDEO 21: WHILE III: Do-While
------------------------------
-> DO-WHILE: Ejecuta el codigo de su interior al menos una vez.
*/

using System;

namespace _21._WHILE_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // -------------------------------
            // Ejemplo 1: Impresion de valores
            // -------------------------------
            int z = 5;
            do
            {
                Console.WriteLine($"Valor de z: {z}");
                z++;
            }
            while (z < 10);
            */

            // -------------------------------
            // Ejemplo 2: Codigo clase enterior
            // -------------------------------
            Console.WriteLine("CUAL ES EL NUMERO ALRATORIO");
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);

            int intentos = 0;
            int miNumero;
            System.Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {
                intentos++;
                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > aleatorio)
                    System.Console.WriteLine("El numero es mas bajo");
                if (miNumero < aleatorio)
                    System.Console.WriteLine("El numero es mas alto");
            }
            while (aleatorio != miNumero);

            System.Console.WriteLine($"CORRECTO !! Has utilizado {intentos} intentos");
        }
    }
}



