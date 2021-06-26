/*
----------------------------
VIDEO 14: CONDICIONALES IF I
----------------------------
-> Operadores de comparacion
    -> == : Igual que
    -> != : Diferente que
    -> <  : Menor que
    -> <= : Menor igual que
    -> >  : Mayor que
    -> >= : Mayor igual que

-> Operadores de comparacion
    -> && : Y Logigo
    -> || : O Logico

-> Sintaxis: If (condicion) { Codigo a ejecutar si es verdad }
*/

using System;

namespace _14._CONDICIONAL_IF_I
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------
            // Declaracion de variables booleanas
            // ----------------------------------
            bool haceFrio = true;
            System.Console.WriteLine($"Hace frio: {haceFrio}");
            Console.WriteLine("");

            // --------------------------------------------
            // ! Invierte el valor de la variable booleana
            // --------------------------------------------
            var haceCalor = !haceFrio;
            System.Console.WriteLine($"Hace calor: {haceCalor}");
            Console.WriteLine("");

            // --------------
            // Condicional 1
            // --------------
            int edad = 20;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            if (edad >= 18)
            {
                System.Console.WriteLine("Eres mayor de edad");
            }
        }
    }
}
