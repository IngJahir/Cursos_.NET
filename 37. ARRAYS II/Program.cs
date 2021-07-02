/*
--------------------
VIDEO 37: ARRAYS II
--------------------
-> Arrays implicitos: Array que no especifica el tipo de datos, ni cuantos datos almacena
-> Arrays de objetos
-> Arrays de tipos anonimos
*/
using System;

namespace _37._ARRAYS_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS");

            // Array implicito de caracteres y nuimeros
            // -----------------------------------------
            Console.WriteLine("Array implicito de caracteres y numeros");
            var datos = new[] { "Jahir", "Tautiva", "15" };
            var valores = new[] { 10, 20, 30, 45, 50.25 };
            Console.WriteLine("");

            // Array de objetos metodo 1
            // -------------------------
            Console.WriteLine("Array de objetos metodo 1");
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = new Empleados("Pepito", 35);
            Console.WriteLine("");

            // Array de objetos metodo 2
            // -------------------------
            Console.WriteLine("Array de objetos metodo 2");
            Empleados Anita = new Empleados("Ana", 27);
            Empleados Carlos = new Empleados("Carlos", 32);
            Empleados[] arrayEmpleados_2 = new Empleados[] { Anita, Carlos };
            Console.WriteLine("");

            // Arrays de clases anonimos
            // -------------------------
            Console.WriteLine("Array de clases anonimas");
            var persona = new[]
            {
                new { Nombre ="Juan", Edad=19},
                new { Nombre ="Gabriel", Edad=29},
                new { Nombre ="Juanita", Edad=32}
            };

            Console.WriteLine(persona[1]);
        }
        
        class Empleados
        {
            private string nombre;
            private int edad;

            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        }
    }
}
