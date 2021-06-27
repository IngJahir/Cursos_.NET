/*
------------------
VIDEO 20: WHILE II
------------------
*/
using System;

namespace _20._WHILE_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CUAL ES EL NUMERO ALRATORIO");
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int miNumero = 101;
            int intentos = 0;

            System.Console.WriteLine("Intrude un numero entre0 y 100");

            while (aleatorio != miNumero)
            {
                intentos++;
                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > aleatorio)
                    System.Console.WriteLine("El numero es mas bajo");
                if (miNumero < aleatorio)
                    System.Console.WriteLine("El numero es mas alto");
            }

            System.Console.WriteLine($"CORRECTO !! Has utilizado {intentos} intentos");
        }
    }
}
