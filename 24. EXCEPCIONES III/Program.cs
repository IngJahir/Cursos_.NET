/*
--------------------------
VIDEO 24: EXCEPCIONES III
--------------------------
-> Conflictos con excepciones:  Al hacer catch (Exception ex) se consideran TODAS las
                                excepciones. Por lo tanto escribir un catch despues
   del anterior GENERE UN ERROR. La forma correcta de escribir el codigo es escribir
   la excepcion especifica y luego la general. 

-> Excepcion con filtros
-> Uso de Checked o Se puede configurar el cheked en las opciones de compilacion !!!
*/

using System;

namespace _24._EXCEPCIONES_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ----------------------------------------------------------------------
            // Caso 1: Se escribe primero la excepcion especifica y luego la general
            // ----------------------------------------------------------------------
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
                // Excepcion especifica
                // ---------------------
                catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido texto");
                    miNumero = 0;
                }
                // Excepcion general
                // -----------------
                catch (Exception ex)
                {
                    Console.WriteLine("Ha habido un Error!!. Se toma como nuero inicial 0");
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

            /*
            // -------------------------------
            // Caso 2: Alternativa con filtro
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
                // Excepcion general con filtro
                // -----------------------------
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un Error!!. Se toma como nuero inicial 0");
                    miNumero = 0;
                }
                // Filtro
                // -------
                catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido texto. Se toma como nuero inicial 0");
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

            // --------------------
            // Caso 3: Uso Checked
            // ---------------------
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;
                Console.WriteLine(numero);
            }
        }
    }
}
