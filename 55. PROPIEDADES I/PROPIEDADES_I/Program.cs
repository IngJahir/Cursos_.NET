/*
-------------------------
VIDEO 55: PROPIUEDADES I
-------------------------
-> Properties: 
    * No permiten acceder a los campos desde otra clase para violar las reglas que se han programado
    * Permite usar una sintaxis mucho mas sencilla cuando se hacen otras operaciones

*/
using System;

namespace PROPIEDADES_I
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // -----------------------------
            // Alternativa 1: Sin properties
            // -----------------------------

            Empleado oJuan = new Empleado("Juan");
            oJuan.setSalario(1200);
            Console.WriteLine($"El salario de Juan es: {oJuan.getSalario()}");

            //Aumento de salario
            double nuevoSalario = oJuan.getSalario()+300;
            Console.WriteLine($"El salario aumentado es: {nuevoSalario}");
            */

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

    /*
    // -----------------------------
    // Alternativa 1: Sin properties
    // -----------------------------
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

        // Metodos publicos
        // ----------------
        public void setSalario(double salario) 
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asignara 0 como salario");
                this.salario = 0;
            }
            else 
            {
                this.salario = salario;
            }
        }

        public double getSalario() 
        {
            return salario;
        }
    }
    */

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
            get { return this.salario; }
            set { this.salario = evaluaSalario(value); }
        }
    }
}
