
/*
------------------------------------------
VIDEO 40: ARRAYS V: Arrays por parametros
------------------------------------------
-> Arrays como parametros de metodos
-> Arrays como devolucion de metodos
*/
using System;
using System.Linq.Expressions;

namespace _40._ARRAYS_V
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------
            // Envio de arreglo
            // ----------------
            // Creacion de arreglo de numeros y envio de arreglo
            int[] numeros = new int[4] { 7, 5, 3, 2 };
            ProcesaDatos(numeros);

            // Impresion de los numeros
            foreach (var numero in numeros)
            {
                Console.WriteLine($"{numero}");
            }

            // ---------------------
            // Recepcion de arreglo
            // ---------------------
            // Llamado al metodo
            int[] arrayElementos = LeerDatos();

            // Impresion de los datos
            int con = 0;
            foreach (var elemento in arrayElementos)
            {
                Console.WriteLine($"Elemento [{con}]: {elemento}");
                con++;
            }
        }
        static void ProcesaDatos(int[] datos)
        {
            for (var i = 0; i < datos.Length; i++)
            {
                datos[i] += 10;
            }
        }
        static int[] LeerDatos()
        {
            // Cpaturando dimension del arreglo
            Console.WriteLine($"Numero de elementos del arreglo");
            int numElementos = Int32.Parse(Console.ReadLine());

            // Declarar arreglo
            int[] datos = new int[numElementos];

            for (var i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Dato [{i}]:");
                datos[i] = Int32.Parse(Console.ReadLine());
            }

            return datos;
        }
    }
}
