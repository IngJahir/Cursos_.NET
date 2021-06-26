/*
------------------------------
VIDEO 16: CONDICIONALES IF III
------------------------------
-> String.compare(carnet,"si",true)
*/
using System;

namespace _16._CONDICIONAL_IF_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // -------------------------------
            // Ejemplo 1: Condicional anidado
            // -------------------------------
            string card = "no";
            Console.WriteLine("Condicional con varias condiciones");

            Console.WriteLine("Introduce tu edad");
            int age = Int32.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("¿Tienes carnet ?");

                // El metodo compare compara caracteres sin importar si son mayusculas o minusculas
                // Si es verdadero, retorna 0
                card = Console.ReadLine();
                int compara = String.Compare(card, "si", true);

                if (compara == 0)
                    Console.WriteLine("Puedes conducir vehiculo ya que eres mayor de edad y tienes carnet");
                else
                    Console.WriteLine("Eres mayor de edad pero no puedes conducir por que no tienes carnet ");
            }
            else
                Console.WriteLine("Eres menor de edad, por lo tanto no puedes conducir");
            Console.WriteLine("");
            */

            // ----------------------------------------
            // Ejemplo 2: Calculo de promedio de notas
            // ----------------------------------------
            System.Console.WriteLine("Introduce la nota 1");
            float nota_1 = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Introduce la nota 2");
            float nota_2 = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Introduce la nota 3");
            float nota_3 = Int32.Parse(Console.ReadLine());

            // Caso 1: Con notas superiores a 5
            // ---------------------------------
            Console.WriteLine("Caso con todos las notas aprobadas");
            if (nota_1 >= 5 && nota_2 >= 5 && nota_3 >= 5)
            {
                float promedio = (nota_1 + nota_2 + nota_3) / 3;
                System.Console.WriteLine($"La nota media es: {promedio}");
            }
            else
                Console.WriteLine("Vuelve en Septiembre");
            Console.WriteLine("");

            // Caso 2: Con alguna nota superior a 5
            // ---------------------------------
            Console.WriteLine("Caso con alguna nota mayor a 5");
            if (nota_1 >= 5 || nota_2 >= 5 || nota_3 >= 5)
            {
                float promedio = (nota_1 + nota_2 + nota_3) / 3;
                System.Console.WriteLine($"La nota media es: {promedio}");
            }
            else
                Console.WriteLine("Vuelve en Septiembre");
            Console.WriteLine("");
        }
    }
}
