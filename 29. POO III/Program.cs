/*
-----------------------------------------------
VIDEO 29: POO III: Encapsulacion y convenciones
-----------------------------------------------
-> Encapsulacion: Para encapsular hay que usar la palabra private
-> Las propiedades MODIFICABLES se dejan publicas
-> Las propiedades NO MODIFICABLES se dejan privadas
-> Conveciones:
    * Los identificadores "public" deben comenzar en mayuscula. Ejemplo: public double CalculoArea() {}
    * Los identificadores que no son "public" deben empezar en minuscula. private double longitudRadio() {}
*/
using System;

namespace _29._POO_III
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion e instantacion del objeto circulo
            Circulo miCirculo_1 = new Circulo();
            Circulo miCirculo_2 = new Circulo();

            Console.WriteLine($"El area del circulo_1 es {miCirculo_1.CalculoArea(5)}");
            Console.WriteLine($"El area del circulo_2 es {miCirculo_2.CalculoArea(9)}");
            Console.WriteLine("");

            Console.WriteLine("COVERSION EURO DOLLAR");
            ConversoEuroDolar oCantidad = new ConversoEuroDolar();

            // Cambio de valor del euro
            // ------------------------
            oCantidad.cambiaValorEuro(-1.52);
            Console.WriteLine($"El valor de 50 euros en dolares es: {oCantidad.Convierte(50)}");
            Console.WriteLine("");
        }

        // Nuevas clases
        // -------------
        class Circulo
        {
            // Propiedades de la clase o campo de clase
            public const double PI = 3.1416;

            // Comportamientos.
            public double CalculoArea(int radio) => PI * Math.Pow(radio, 2);
        }

        class ConversoEuroDolar
        {
            private double euro = 1.253;
            public double Convierte(double cantidad) => cantidad * euro;

            public void cambiaValorEuro(double nuevoValor)
            {
                if (nuevoValor < 0)
                    euro = 1.253;
                else
                    euro = nuevoValor;
            }
        }
    }
}
