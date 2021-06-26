/*
------------------------------
VIDEO 15: CONDICIONALES IF II
------------------------------
*/
using System;

namespace _15._CONDICIONAL_IF_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------------------
            // Las llaves del condicional se pueden omitir si solo hay una linea de codigo
            // ---------------------------------------------------------------------------
            int edad = 20;
            Console.WriteLine("Condicional de una linea");
            if (edad >= 18)
                System.Console.WriteLine("Eres mayor de edad");
            Console.WriteLine("");

            // ---------------------------------
            // Condicional con booleanas y else 
            // --------------------------------
            Console.WriteLine("Vamos evaluar si puedes conducir");
            bool carnet = false;
            if (carnet)
                Console.WriteLine($"Puedes conducir vehiculo");
            else
                Console.WriteLine($"No puedes conducir vehiculo");

            Console.WriteLine("");

            // ----------------------------------
            // Condicional con varias condiciones
            // ----------------------------------
            Console.WriteLine("Condicional con varias condiciones");

            Console.WriteLine("Introduce tu edad");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tienes carnet");
            string card = Console.ReadLine();

            if ((age >= 18) && (card == "si")) Console.WriteLine("Puedes conducir vehiculo");
            else Console.WriteLine("No puedes conducir vehiculo");
            Console.WriteLine("");
        }
    }
}
