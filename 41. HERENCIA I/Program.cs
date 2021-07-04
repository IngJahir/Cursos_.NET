/*
-----------------------------------
VIDEO 41: HERENCIA I: Definiciones
-----------------------------------
-> Herencia: Reutilizacion de otras clases

-> Principio de diseño de herencia "es-un"
    * Un Jefe es un Empleado? Si es si la respuesta, entonces Jefe hereda de empleado
    * Un Director es un Empleado? Si es si la respuesta, entonces Director hereda de empleado
    * Un Empleado es un Jefe? No necesariamente, un Empleado puede ser un mensajero, un recepcionista...

-> Jerarquia opcion 1
    * Empleado
        * Jefe
        * Director

-> Jerarquia opcion 2
    * Empleado
        * Jefe
            * Director

-> Clase mamiferos    
    * Caballo
    * Humanos
    * Gorila
*/
using System;

namespace _41._HERENCIA_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definiciones");
        }
    }
}
