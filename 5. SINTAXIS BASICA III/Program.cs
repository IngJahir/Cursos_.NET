/*
----------------------------
VIDEO 5: SINTAXIS BASICA III
----------------------------
-> Operadores aritmetcos:
    -> +   : Suma
    -> ++  : Adiciona 1 a una variable
    -> +=5 : Adiciona 5 a una variable
    -> -   : Resta
    -> --  : Resta 1 a una variable
    -> -=5 : Resta 5 a una variable
    -> *   : Multiplicacion
    -> /   : Division
    -> %   : Residuo / Modulo

-> Interpolacion de strings: Concatenacion de strings pero sin utilizar el operador + 
*/

using System;

namespace _5._SINTAXIS_BASICA_III
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplicacion, division y residuo
            Console.WriteLine(7*5);
            Console.WriteLine(5.0/2.0);
            Console.WriteLine(9%2);

            int edad = 19;
            // Sin interpolacion de strings
            Console.WriteLine("Tienes una edad de: " + edad + " años");

            // Incrementa en 1 la edad e interpolacion de strings 
            edad++;
            Console.WriteLine($"Tienes una edad de: {edad} años");

            // CASO ESPECIAL: La edad se incrementa DENTRO del Console.WriteLine !!!
            Console.WriteLine("Tienes una edad de: "+ ++edad +" años");

            edad+=8;
            Console.WriteLine($"Tienes una edad de: {edad} años");

            
        }
    }
}
