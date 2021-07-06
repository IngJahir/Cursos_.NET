/*
-------------------------
VIDEO 56: PROPIEDADES II
-------------------------
-> Para este caso se utlizan las expresion body con operador lambda
-> Para generar una propiedad de solo escritura, se borra el get
-> Para generar una propiedad de solo lectura, se borra el set

*/
using System;

namespace PROPERTIES_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------
            // Alternativa 2: Con properties
            // -----------------------------
            Empleado oJuan = new Empleado("Juan");
            oJuan.SALARIO = 1200;
            Console.WriteLine($"El salario de Juan es: {oJuan.SALARIO}");

            //Aumento de salario
            oJuan.SALARIO += 500;
            Console.WriteLine($"El salario aumentado es: {oJuan.SALARIO}");
        }
    }

    // ---------------------------------
    // Alternativa 2: Usando properties
    // --------------------------------
    class Empleado
    {
        // Campor de clase
        // ---------------
        private double salario;
        private string nombre;

        // Constructor
        // -----------
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }

        // CREACION DE PROPIEDADES
        // -----------------------
        public double SALARIO
        {
            get => this.salario;
            set => this.salario = evaluaSalario(value);
        }
    }
}
