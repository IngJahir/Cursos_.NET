/*
----------------
VIDEO 18: SWITCH
----------------
-> Sintaxis:
    Switch(expresion de contro)
    {
        case expresion constante:
            codigo a realizar
            break;

        case expresion constante:
            codigo a realizar
            break;

        default:
            codigo a realizar
            break;    
    }
-> A tener en cuenta:
    * Cada expresion constante a de ser unica
    * Solo se puede usar el switch para evaluar: int, char, string
    * Los case solo pueden contener expresiones constantes
    * Todos los case deben llevar su break, se puede utilizar return y thrown
*/
using System;

namespace _18._SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // --------------------------------
            // Ejemplo 1: Medios de transporte
            // --------------------------------
            Console.WriteLine("Elige medio de transporte(coche, tren o avion)");
            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media 800 km/h");
                    break;

                default:
                    Console.WriteLine("Transporte no contemplado");
                    break;
            }
            */

            // --------------------------------
            // Ejemplo 2: Calculo de comisiones 
            // --------------------------------
            Console.WriteLine("Introduce el numero del mes para el calculo de la comision");
            int nMes = Int32.Parse(Console.ReadLine());
            switch (nMes)
            {
                case 1:
                    System.Console.WriteLine("Mes escogido: Enero");
                    break;

                case 2:
                    System.Console.WriteLine("Mes escogido: Febrero");
                    break;

                case 3:
                    System.Console.WriteLine("Mes escogido: Marzo");
                    break;

                case 4:
                    System.Console.WriteLine("Mes escogido: Abril");
                    break;

                case 5:
                    System.Console.WriteLine("Mes escogido: Mayo");
                    break;

                case 6:
                    System.Console.WriteLine("Mes escogido: Junio");
                    break;

                case 7:
                    System.Console.WriteLine("Mes escogido: Julio");
                    break;

                case 8:
                    System.Console.WriteLine("Mes escogido: Agosto");
                    break;

                case 9:
                    System.Console.WriteLine("Mes escogido: Septiembre");
                    break;

                case 10:
                    System.Console.WriteLine("Mes escogido: Octubre");
                    break;

                case 11:
                    System.Console.WriteLine("Mes escogido: Noviembre");
                    break;

                case 12:
                    System.Console.WriteLine("Mes escogido: Diciembre");
                    break;

                default:
                    System.Console.WriteLine("Mes incorrecto");
                    break;
            }
        }
    }
}
