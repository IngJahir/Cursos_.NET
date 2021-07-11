/*
-----------------------------------------
VIDEO 68: DELEGADOS_PREDICADOS_LAMBDA II
-----------------------------------------
-> DELEGADOS PREDICADOS:
    * Son delegados que devuelven true o false
    * Son muy utilizados para filtrar listas de valores comprobando si una condicion es cierta para 
      un valor dado.
    * Sintaxis: Predicate<T> NombrePredicado = new Predicate<T>(funcionDelegado)
*/
using System;
using System.Collections.Generic;

namespace DELEGADOS_PREDICADOS_LAMBDA_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------
            // Ejemplo 1: Lista de numeros
            // ----------------------------

            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declaramos delegado predicado
            Predicate<int> elDelegadoPredicado = new Predicate<int>(DamePares);

            // Lista de numeros enteros
            List<int> numerosPares = listaNumeros.FindAll(elDelegadoPredicado);

            // Impresion de datos
            foreach ( int num in numerosPares)
            {
                Console.WriteLine($"El numero es: {num}");
            }
            Console.WriteLine("");

            // ------------------------------
            // Ejemplo 2: Filtro con objetos
            // ------------------------------
            List<Personas> gente = new List<Personas>();
            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Maria";
            P2.Edad = 27;

            Personas P3 = new Personas();
            P3.Nombre = "Ana";
            P3.Edad = 37;

            // Agregando datos a gente
            gente.AddRange(new Personas[] { P1, P2, P3 });

            // Creacion del delegado predicado
            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(elPredicado);
            if (existe) Console.WriteLine("Hay personas que se llaman Juan");
            else Console.WriteLine("No hay nadie llamado Juan");
            Console.WriteLine("");

            Predicate<Personas> elPredicado_2 = new Predicate<Personas>(ExisteMayoresEdad);
            bool existe_2 = gente.Exists(elPredicado_2);
            if (existe_2) Console.WriteLine("Hay personas mayores de edad");
            else Console.WriteLine("No hay mayores de edad");
            Console.WriteLine("");
        }

        static bool DamePares(int num) 
        {
            if (num % 2 == 0) return true;
            else return false;
        }

        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }

        static bool ExisteMayoresEdad(Personas persona)
        {
            if (persona.Edad >= 18 ) return true;
            else return false;
        }
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
