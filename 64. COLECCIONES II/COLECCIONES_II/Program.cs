/*
------------------------------------
VIDEO 64: COLECCIONES II: LinkedList
------------------------------------
-> En cuanto a utilida y funcionamiento las List y las LinkedList son similares

-> List: Almacenan los datos en pocisiones adyacentes de la memoria del pc,
         esto implica que al eliminar un elemento queda vacia la pocision de 
   memoria y el sistema vuelve y "desplaza" los datos. Esto NO ES EFICIENTE.

-> LinkedList: Es una coleccion de LinkedListNode<T>; los nodos son lugares 
               de memoria donde se almacena la informacion). Los nodos tienen 
   dos enlces o polos que conectan con el nodo anterior y el nodo siguiente.
   Al eliminar un dato se actualiza los enlaces y no hay "desplazamiento".
   Esto ES MAS EFICIENTE !!!.
-> 

*/
namespace COLECCIONES_II
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones oOperaciones = new Operaciones();

            // --------------------------
            // OPERACIONES CON LINKEDLIST
            // --------------------------

            // 1. Declaracion de LinkedList
            // -----------------------------
            LinkedList<int> numeros = new LinkedList<int>();

            // 2.1 Adicion de elementos con AddFirst
            // -------------------------------------
            foreach (var numero in new int[]{10,8,6,4,2,0})
            {
                numeros.AddFirst(numero);
            }

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Lista con AddFirst");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // 2.2 Adicion de elementos con AddLast
            // ------------------------------------
            foreach (var numero in new int[] { 45, 65, 70, 75, 85, 95 })
            {
                numeros.AddLast(numero);
            }

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Lista con AddLast");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // Alternativa para imprimir
            // -------------------------
            for (LinkedListNode<int> nodo = numeros.First; nodo!=null; nodo=nodo.Next  ) 
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);   
            }
            Console.WriteLine("");

            // 3. Eliminar un elemento
            // -----------------------
            numeros.Remove(6);

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Lista con Remove");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

            // 4. Creacion y adicion de nodo
            // ----------------------------
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15000);
            numeros.AddFirst(nodoImportante);

            // Imprimiendo datos
            // -----------------
            Console.WriteLine("Adicion de nodo");
            oOperaciones.imprimirDatos(numeros);
            Console.WriteLine("");

        }

        class Operaciones
        {
            public void imprimirDatos(LinkedList<int> numeros)
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
