/*
----------------------------------
VIDEO 35: POO IX: Clases anonimas
----------------------------------
-> Importar metodos static
-> Clases anonimas: Son clases que no tienen nombres; se utilizan para expresiones query
    * Restricciones:
        - Solo pueden contener campo publicos
        - Todos los campos deben estar iniciados
        - Los campos no pueden ser static
        - No se pueden definir metodos
*/
using System;
//using static System.Math;

namespace _35._POO_IX
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            /*
            // ----------------------------------------------------------------------------------
            // En la seccion de using se declara la libreria math, esto reduce la linea de codigo 
            // ----------------------------------------------------------------------------------
            double raiz = Sqrt(9);
            double potencia = Pow(3, 4);
            Console.WriteLine(raiz);
            Console.WriteLine(potencia);
            */

            // -------------------------------------------------------------
            // Creacion de clase anonima, no se especifica el tipo de datos. 
            // -------------------------------------------------------------
            var miVariable = new { Nombre = "Jahir", Edad = 38 };
            Console.WriteLine($"El nombre es: {miVariable.Nombre}");
            Console.WriteLine($"La edad es: {miVariable.Edad}");
            Console.WriteLine("");

            // Ya que llevan el mismo orden y el mismo tipo de variables, entonces la clase es la misma
            // ----------------------------------------------------------------------------------------- 
            var otraVariable = new { Nombre = "Anita", Edad = 28 };
            Console.WriteLine($"El nombre es: {miVariable.Nombre}");
            Console.WriteLine($"La edad es: {miVariable.Edad}");
            Console.WriteLine("");
            //miVariable = otraVariable;
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otroPunto = new Punto();
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Numero de objetos creados; {Punto.ContadorDeObjeto()}");
        }
    }
}
