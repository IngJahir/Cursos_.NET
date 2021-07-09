/*
-----------------------
VIDEO 63: COLECCIONES I
-----------------------
-> Colecciones:
    * Son clases que pertenecen al namespace System.Collection.Generic
    * Estas clases permiten almacenar elementos.
    * Son clases genericas
    * No tienen las limitacioes de los array (A cambio de mayor consumo de recursos)
    * Permten: Ordenar, añadir, eliminar, buscar, etc.
    * Permiten almacenar elementos de un array
    
-> Colecciones mas frecuentes:
    * List<T> : Parecidos a los array pero con metodos adcionales para agregar, eliminar, ordenar, buscar, etc.
    * Queue<T> : Las "colas". Un elemento entra y el otro sale. Primero en entrar - primero en salir.
    * Stack<T> : Parecido a las Queue pero con algunas diferencias. Primero en entrar - ultimo en salir
    * LinkedList <T> Comportamiento como Queue o Stack pero con acceso aleatorio
    * HashSet<T> Lista de valores sin ordenar
    * Dictionary<TKey,Tvalue>: Almacena elememtos con estructura de clave-valor
    * SortedList<TKey,Tvalue>: Igual que los Diccionarios pero ordenados.
*/
namespace COLECCIONES_I
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones oOperaciones = new Operaciones();

            // ---------------------
            // OPERACIONES CON LISTA
            // ---------------------

            // 1. Declaracion de lista
            // ------------------------
            List<int> numeros = new List<int>();

            // 2. Adicion de un elemento
            // ----------------------
            numeros.Add(5);
            numeros.Add(7);
            numeros.Add(10);

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Primera lista");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // 3. Agregar a una lista desde un arreglo
            // ------------------------------------
            int[] listaNumeros = new int[] { 3, 6, 9, 12, 15 };
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Segunda lista");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // 4.1 Agregar datos en ejecucion
            // ----------------------------- 
            Console.WriteLine("'¿Cuantos elementos quieres introducir?");
            int elem = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine($"Valor {i + 1}: ");
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Tercera lista");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // 4.2 Introducir elementos
            // ------------------------
            Console.WriteLine("Introduce numero de elementos en la coleccion (0 para salir)");
            int val = 1;
            while (val != 0)
            {
                val = Int32.Parse(Console.ReadLine());
                numeros.Add(val);
            }

            // 5. Remover el elemento 0
            // ------------------------
            numeros.RemoveAt(numeros.Count - 1);

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Tercera lista");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // 5. Contar los datos de la lista
            // -------------------------------
            Console.WriteLine($"El numero de elementos de la lista es: {numeros.Count}");
        }

        class Operaciones
        {
            public void imprimirDatos(List<int> numeros)
            {
                var pos = 0;
                foreach (var numero in numeros)
                {
                    Console.WriteLine($"Numero [{pos}]: {numero}");
                    pos++;
                }
            }
        }
    }
}
