/*
---------------------
VIDEO 12: METODOS IV
---------------------
-> Ambito o alcance o contexto del Metodo: Todo el codigo que esta dentro de los {}
-> Sobrecarga de metodos: Repetir el metodo pero con diferente numero de parametros; en caso de tener el mismo numero de
                          parametros, estos deben ser de diferente tipo
*/

using System;

namespace _12._METODOS_IV
{
    class Program
    {
        // Variables de ambito de clase o campos de clase
        int nro_1 = 5;
        int nro_2 = 7;

        static void Main(string[] args)
        {
            var caso_1 = Suma(2, 3);
            var caso_2 = Suma(2, 3.5);
            var caso_3 = Suma(2, 3, 4);
            Console.WriteLine("CASOS DE USO PARA SUMA");
            Console.WriteLine($"Suma para el caso 1: {caso_1}");
            Console.WriteLine($"Suma para el caso 2: {caso_2}");
            Console.WriteLine($"Suma para el caso 3: {caso_3}");
        }

        // ------------------------------
        // Ejemplos de Ambitos de Metodo
        // ------------------------------
        void sumaNumeros()
        {
            System.Console.WriteLine($"La suma es: {nro_1 + nro_2}");
        }

        void segundoMetodo()
        {
            Console.WriteLine(nro_1);
        }

        // ----------------------------------
        // Ejemplos de sobrecarga de Metodos
        // ----------------------------------
        static int Suma(int operador1, int operador2) => operador1 + operador2;
        static double Suma(int operador1, double operador2) => operador1 + operador2;
        static int Suma(int operador1, int operador2, int operador3) => operador1 + operador2 + operador3;

    }
}
