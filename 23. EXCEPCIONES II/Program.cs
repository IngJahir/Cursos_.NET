/*
------------------------
VIDEO 23: EXCEPCIONES II
------------------------
-> Capturar varias excepciones
    Try{}
    catch(FormatException e){ Codigo a ejecutar si hay FormatException }
    catch(OverFlowException e){ Codigo a ejecutar si hay OverFlowException}

-> Herencia de excepciones: 
    * Exception
        *SystemException
            * FormatException
            * OverflowException
*/
using System;

namespace _23._EXCEPCIONES_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // -------------------------------
            // Caso 1: Usando SystemException
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

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No has introducido un valor numerico valido. Se toma como nuero inicial 0");
                    miNumero = 0;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("No has introducido un valor demasiado alto. Se toma como nuero inicial 0");
                    miNumero = 0;
                }

                if (miNumero > aleatorio)
                    System.Console.WriteLine("El numero es mas bajo");
                if (miNumero < aleatorio)
                    System.Console.WriteLine("El numero es mas alto");
            }
            while (aleatorio != miNumero);

            System.Console.WriteLine($"CORRECTO !! Has utilizado {intentos} intentos");
            */

            // -------------------------------------------------------------------------------------
            // Caso 2: Usando Exception: Se captura todas las excepciones y se digita un solo catch
            // -------------------------------------------------------------------------------------
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
                catch (Exception ex)
                {
                    Console.WriteLine("No has introducido un valor numerico valido. Se toma como nuero inicial 0");
                    Console.WriteLine(ex.Message);
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
