/*
------------------
VIDEO 36: ARRAYS I
------------------
-> Arrays: 
    - Estructuras de datos que contienen una coleccion de valores del mismo tipo.
    - Sirven para almacenar valores que normalmente tienen alguna relacion entre si
    - Declaracion: int[] mi_matriz;
    - Iniciacion y dimension del array: mi_matriz = new int[4]
    - Posiciones y valor: mi_matriz[0] = 15;
    - Asignacion de valores int[] mi_matriz = {15, 25, 8, -7, 92}
*/
using System;

namespace _36._ARRAYS_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS");

            // Metodo 1: Declaracion de arreglo y llenado
            // ------------------------------------------
            Console.WriteLine("Metodo 1");
            int[] edades_1 = new int[4];
            edades_1[0] = 15;
            edades_1[1] = 25;
            edades_1[2] = 35;
            edades_1[3] = 45;
            Console.WriteLine($"Valor del arreglo en la posicion 1: {edades_1[1]}");
            Console.WriteLine("");

            // Metodo 2: Llenado del arreglo de forma directa
            // ----------------------------------------------
            Console.WriteLine("Metodo 2");
            int[] edades_2 = { 15, 25, 8, 10 };
            Console.WriteLine($"Valor del arreglo en la posicion 3: {edades_2[3]}");
            Console.WriteLine("");

            // Metodo 3: Llenado del arreglo de forma directa pero con limite de datos
            // -----------------------------------------------------------------------
            Console.WriteLine("Metodo 3");
            int[] edades_3 = new int[4] { 15, 25, 8, 10 };
            Console.WriteLine($"Valor del arreglo en la posicion 1: {edades_3[1]}");
            Console.WriteLine("");
        }
    }
}
