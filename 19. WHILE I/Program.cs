/*
------------------
VIDEO 19: WHILE I
------------------
-> Bucles: Permiten reperir la ejecucion de lineas de codigo un numero determinado o indeterminado de veces
-> Ventajas:
    * Permiten repetir codigo de forma rapida y sencilla
    * Ahorro de tiempo a la hora dde programar
    * Permite trabajar con grandes volumenes de datos
    * Permite trabajar con arrays
-> Clasificacion:
    * Determinados: Sabemos cuantas veces repiten el codigo de su interior (For)
    * Indeterminados: No sabemos cuantas veces repiten el codigo interior (While, Do-While)
-> Sintaxis:
    while (Condicion a evaluar[true o false]) {Codigo a repetir}
*/

using System;

namespace _19._WHILE_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitud de informacion
            // ------------------------
            Console.WriteLine("USO DE CICLO WHILE");
            Console.WriteLine("Deseas usar el ciclo while");
            string respuesta = Console.ReadLine();

            // Ejecucion ciclo while
            // --------------------- 
            while (respuesta != "no")
            {
                Console.WriteLine($"Estas ejecutando el ciclo while");
                Console.WriteLine($"Introduce tu nombre, por favor");
                string nombre = Console.ReadLine();

                Console.WriteLine($"{nombre} saldras del ciclo cuando escrbas 'no'");
                System.Console.WriteLine("¿Deseas repetir otra vez?");
                respuesta = Console.ReadLine();
            }

            // Mensaje de salida
            // -----------------
            System.Console.WriteLine("Has salido del bucle exitosamente !!!");
        }
    }
}
