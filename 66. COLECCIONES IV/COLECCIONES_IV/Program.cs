/*
---------------------------------------------
VIDEO 66: COLECCIONES IV: Stack y Dictionary
---------------------------------------------
-> Stack
    * L.I.F.O: Ultimas en Entrar - Primeras en salir
    * Push para introducir elementos
    * Pop para eliminar elementos
    
-> Coleccion Dictionary
    * Elementos con Clave - Valor
*/

using System;
using System.Collections.Generic;

namespace COLECCIONES_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------
            // OPERACIONES CON STACK
            // ----------------------

            // Definir la pila
            Stack<int> numeros = new Stack<int>();

            // Agregar elementos a la pila
            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Push(numero);
            }

            // Recorriendo la pila
            Console.WriteLine("Recorriendo la pila");
            var pos = 0;
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Numero[{pos}]: {numero}");
                pos++;
            }
            Console.WriteLine("");

            // Eliminar elementos de la pila
            Console.WriteLine("Eliminando elementos");
            numeros.Pop();
            pos = 0;
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Numero[{pos}]: {numero}");
                pos++;
            }
            Console.WriteLine("");

            // ------------------------
            // OPERACIONES CON LIBRARY
            // ------------------------

            // Definir el diccionario
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenar el dicionario
            edades.Add("Juan",28);
            edades.Add("Diana", 35);

            // Alternativa para rellenar dicccionario
            edades["Maria"] = 25;
            edades["Antonio"] = 29;

            // Recorrer diccionario
            foreach (KeyValuePair<string,int> persona in edades)
            {
                Console.WriteLine("Nombre: {0} Edad: {1}", persona.Key, persona.Value );
            }
        }
    }
}
