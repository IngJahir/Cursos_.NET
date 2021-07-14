/*
------------------------------------------
VIDEO 69: DELEGADOS_PREDICADOS_LAMBDA III
------------------------------------------
-> Expresiones Lambda
    * Funciones anonimas que no tienen un nombre
    * Se emplean para ejecutar funciones que no necesitan ser nombradas
    * Se emplean para simplificar codigo, en expresiones Query, etc.
    
-> Sintaxis: Parametros => expresion / Bloque de sentencia

*/
namespace DELEGADOS_PREDICADOS_LAMBDA_III
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public delegate int OperacionesMatematicas_A(int numero);
        public delegate int OperacionesMatematicas_B(int numero1, int numero2);

        public delegate bool ComparaEdades(int edad1, int edad2);
        public delegate bool ComparaNombres(string nombre1, string nombre2);

        static void Main(string[] args)
        {
            // Sin usar funcion Lambda
            // ------------------------
            Console.WriteLine("Sin uso de la funcion lambda");
            OperacionesMatematicas_A operacion_A = new OperacionesMatematicas_A(Cuadrado);
            Console.WriteLine(operacion_A(4));

            OperacionesMatematicas_B operacion_B = new OperacionesMatematicas_B(Suma);
            Console.WriteLine(operacion_B(3,2));
            Console.WriteLine("");

            // Uso de funcion lambda
            // ---------------------
            Console.WriteLine("Usando la funcion lambda");
            OperacionesMatematicas_A operacion_1 = new OperacionesMatematicas_A(num => num * num);
            Console.WriteLine(operacion_1(4));

            OperacionesMatematicas_B operacion_2 = new OperacionesMatematicas_B((num1,num2) => num1 + num2);
            Console.WriteLine(operacion_2(4,20));
            Console.WriteLine("");

            // Obtencion de numeros pares
            // --------------------------
            Console.WriteLine("Funcion lambda de varias lineas");
            List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            numerosPares.ForEach(numero => {
                Console.WriteLine("El numero par es:");
                Console.WriteLine(numero);  
                });
            Console.WriteLine("");

            // Comparar la edad de dos personas
            // --------------------------------
            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Maria";
            P2.Edad = 27;

            ComparaEdades comparaEdad = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaEdad(P1.Edad,P2.Edad));

            ComparaNombres comparaNombre = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(comparaNombre(P1.Nombre, P2.Nombre));
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Cuadrado(int num) 
        {
            return num * num;
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
