/*
----------------------------
VIDEO 6: SINTAXIS BASICA IV
----------------------------

-> Ver tabla de conversiones implicitas en:
   https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
*/

using System;

namespace _6._SINTAXIS_BASICA_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // -------------------------------------------            
            // Declaracion de variables con el mismo valor
            // -------------------------------------------
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
            Console.WriteLine("Declaracion de variables con el mismo valor");
            Console.WriteLine(edadPersona2);
            Console.WriteLine("");
            */

            /*
            // --------------------------------------------------------            
            // En este caso la unica declaracion con 27 es edadPersona4 
            // --------------------------------------------------------
            int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27;
            edadPersona1 = 10;
            edadPersona2 = 25;
            edadPersona3 = 30;   
            Console.WriteLine("Declaracion de variables unica");         
            Console.WriteLine(edadPersona4);
            Console.WriteLine("");
            */

            /*
            // ----------------------------------            
            // Declaracion implicita de variables 
            // ----------------------------------
            // No se puede cambiar el tipo de variable
            Console.WriteLine("Declaracion de variables implicitas");  
            var edadPersona = 10;
            var nombrePersona = "Jahir"; 
            Console.WriteLine(edadPersona);
            Console.WriteLine(nombrePersona);
            Console.WriteLine("");
            */

            /*
            // -----------------------------         
            // Casteo o conversion explicita 
            // -----------------------------
            Console.WriteLine("Casteo o conversion explicitas de variables");  
            double temperatura = 34.4;
            int tmpBogota = (int)temperatura;
            Console.WriteLine($"Valor decimal de temperatura: {temperatura}");
            Console.WriteLine($"Valor entero de temperatura: {tmpBogota}");
            Console.WriteLine("");
            */

            // ------------------------------------------------------------------------------         
            // Conversion implicita: Se hace entre tipos compables pero de diferente alcance
            // ------------------------------------------------------------------------------
            int nroPersonas = 10000000;
            long nroPersonas2018 = nroPersonas;
            Console.WriteLine("Conversion implicita de variables");
            Console.WriteLine($"El numero de personas es: {nroPersonas2018}");

            // f al final indica que la variable es float
            float pesoMaterial = 5.78f;
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine($"El peso del material es: {pesoMaterialPrec}");
            Console.WriteLine("");            
            
        }
    }
}
