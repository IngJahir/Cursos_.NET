/*
---------------------------
VIDEO 7: SINTAXIS BASICA VI
---------------------------
-> Variables: Espacio en la memoria donde se almacenara un valor que podria cambiar en la 
              ejecucion del programa. 
-> Constantes: Espacio de memoria del ordenador donde se almacenara un valor que no podra cambiar
               en la ejecucuion del programa. 
*/

using System;

namespace _8._SINTAXIS_BASICA_VI
{
    class Program
    {
        static void Main(string[] args)
        {   
            // ---------------------------------------
            // Declaracion de constantes en MAYUSCULAS
            // ---------------------------------------
            const int VALOR_1 = 5;
            const int VALOR_2 = 7;
            System.Console.WriteLine("Declaracion de constantes");
            Console.WriteLine( $"El valor de las constantes son: {0} y {1}", VALOR_1, VALOR_2);
            Console.WriteLine("");

            System.Console.WriteLine("Area del radio");
            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Pow(radio,2)*PI;
            Console.WriteLine($"El area del circulo es: {area}");

        }
    }
}
