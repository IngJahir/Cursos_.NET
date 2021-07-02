/*
-----------------------------------
VIDEO 39: ARRAYS IV: Bucle foreach
-----------------------------------
-> Recorriodo y acceso de arrays con bucle foreach

*/
using System;

namespace _39._ARRAYS_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS");
            Console.WriteLine("------");

            // Array implicito de caracteres y numeros
            // -----------------------------------------
            Console.WriteLine("Array implicito de caracteres y numeros");
            Console.WriteLine("");
            var datos = new[] { "Jahir", "Tautiva", "15" };
            var valores = new[] { 10, 20, 30, 45, 50.25 };

            // Impresion de datos para valores
            Console.WriteLine("Datos personales");
            int con = 0;
            foreach (var dato in datos)
            {
                if (con == 0)
                    Console.WriteLine($"Nombre: {dato}");
                else if (con == 1)
                    Console.WriteLine($"Apellido: {dato}");
                else
                    Console.WriteLine($"Edad: {datos}");
            }

            // Impresion de numeros
            Console.WriteLine("");
            Console.WriteLine("Numeros");
            con = 0;
            foreach (var value in valores)
            {
                Console.WriteLine($"El valor[{con}] es: {value}");
                con++;
            }
            Console.WriteLine("");

            // Array de objetos metodo 1
            // -------------------------
            Console.WriteLine("Array de objetos metodo 1");
            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = new Empleados("Pepito", 35);
            arrayEmpleados[2] = new Empleados("Manuel", 28);
            Console.WriteLine("");

            // Impresion de empleados
            con = 0;
            foreach (var empleado in arrayEmpleados)
            {
                System.Console.WriteLine($"Empleado {con}:");
                Console.WriteLine($"Nombre {empleado.getNombre()}");
                Console.WriteLine($"Edad {empleado.getEdad()}");
                Console.WriteLine("");
                con++;
            }

            // Arrays de clases anonimos
            // -------------------------
            Console.WriteLine("Array de clases anonimas");
            var persona = new[]
            {
                new { Nombre ="Juan", Edad=19},
                new { Nombre ="Gabriel", Edad=29},
                new { Nombre ="Juanita", Edad=32}
            };

            // Impresion de personas
            con = 0;
            foreach (var per in persona)
            {
                System.Console.WriteLine($"Persona {con}:");
                Console.WriteLine($"Nombre {per.Nombre}");
                Console.WriteLine($"Edad {per.Edad}");
                Console.WriteLine("");
                con++;
            }
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

            public string getNombre() => nombre;
            public int getEdad() => edad;
        }
    }
}
