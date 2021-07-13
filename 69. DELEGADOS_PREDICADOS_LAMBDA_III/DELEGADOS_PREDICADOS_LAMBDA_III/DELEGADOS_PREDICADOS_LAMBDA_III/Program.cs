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

        static void Main(string[] args)
        {
            // Sin usar funcion Lambda
            // ------------------------
            OperacionesMatematicas_A operacion_A = new OperacionesMatematicas_A(Cuadrado);
            Console.WriteLine(operacion_A(4));

            OperacionesMatematicas_B operacion_B = new OperacionesMatematicas_B(Suma);
            Console.WriteLine(operacion_B(3,2));

            // Uso de funcion lambda
            // ---------------------
            OperacionesMatematicas_A operacion_1 = new OperacionesMatematicas_A(num => num * num);
            Console.WriteLine(operacion_1(4));

            OperacionesMatematicas_B operacion_2 = new OperacionesMatematicas_B((num1,num2) => num1 + num2);
            Console.WriteLine(operacion_2(4,20));

            List<int> numeros = List<int>



            /*
            List<Personas> gente = new List<Personas>();
            Personas P1 = new Personas();
            P1.Nombre = "Juan";
            P1.Edad = 18;

            Personas P2 = new Personas();
            P2.Nombre = "Maria";
            P2.Edad = 27;
            */
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
