/*
------------------------
VIDEO 22: EXCEPCIONES I
------------------------
-> Excepciones: Errores en tiempo de ejecucion del programa que escapan al control del programador
    * Memoria corrupta
    * Desbordamiento de pila 
    * Sectores de disco duro defectuosos
    * Acceso a ficheros inexistentes
    * Conexiones a BBDD corruptas
    * Otros
-> Bloque try...catch

*/
using System;

namespace _22._EXCEPCIONES_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CUAL ES EL NUMERO ALRATORIO");
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);

            int intentos = 0;
            int miNumero;
            System.Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No has introducido un valor numerico valido. Se toma como nuero inicial 0");
                    miNumero = 0;
                }

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
