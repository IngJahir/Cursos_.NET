/*
-----------------------------------------
VIDEO 65: COLECCIONES III: Colas o Queue
-----------------------------------------
-> F.I.F.O: Primera en Entrar - Primera en Salir
 
*/
using System;
using System.Collections.Generic;

namespace COLECCIONES_III
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------
            // OPERACIONES CON QUEUE
            // ----------------------
            
            // Definir la cola
            Queue<int> numeros = new Queue<int>();

            // Agregar elementos a la cola
            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }

            // Recorriendo la cola
            Console.WriteLine("Recorriendo la cola");
            var pos = 0;
            foreach (int numero in numeros) 
            {
                Console.WriteLine($"Numero[{pos}]: {numero}");
                pos++;
            }
            Console.WriteLine("");

            // Eliminar elementos de la cola
            Console.WriteLine("Eliminando elementos");
            numeros.Dequeue();
            pos = 0;
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Numero[{pos}]: {numero}");
                pos++;
            }
            Console.WriteLine("");
        }
    }


}
