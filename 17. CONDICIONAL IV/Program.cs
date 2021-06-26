/*
------------------------------
VIDEO 17: CONDICIONALES IF IV
------------------------------
*/
using System;

namespace _17._CONDICIONAL_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18) Console.WriteLine("Eres menor de edad");
            else if (edad < 30) Console.WriteLine("Eres joven");
            else if (edad < 60) Console.WriteLine("Eres maduro");
            else Console.WriteLine("Debes cuidarte");
        }
    }
}
