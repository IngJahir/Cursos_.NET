/*
-------------------------
VIDEO 25: EXCEPCIONES IV
-------------------------
-> Forma abreviada de cheked y unchecked; esto solo finciona para variables tipo int y Long
-> Configuracion de Excepciones en C#
-> Lanzamiento de excepciones con throw.
*/
using System;

namespace _25._EXCEPCIONES_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // -----------------------------
            // Uso Checked: Forma abreviada
            // -----------------------------
            Console.WriteLine("USO ABREVIADO CEHKED Y UNCHECKED");
            int numero = int.MaxValue;
            int resultado_1 = checked(numero + 20);
            int resultado_2 = unchecked(numero + 20);
            Console.WriteLine(numero);
            Console.WriteLine("");
            */

            // ---------------------------
            // Lanzamiento de excepciones
            // ---------------------------
            Console.WriteLine("INTRODUCE NUMERO DE MES");
            int numeroMes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine($"El mes {numeroMes} es: {nombre_Mes(numeroMes)}");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Mensaje de la excepcion: " + ex.Message);
            }

            Console.WriteLine("Continua ejecucion");
        }

        public static string nombre_Mes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
