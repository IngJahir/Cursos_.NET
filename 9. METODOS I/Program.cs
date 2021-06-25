/*
------------------
VIDEO 9: METODOS I
------------------
-> Metodos: Grupo de instrucciones  a las que se da un nombre identificativo, que realizan una tarea en concreto. 
-> Para que sirven: Para realizar una tarea en concreto en un momento determinado. Un metodo no realiza su tarea hasta que no es llamado.
-> Sintaxis: tipo_Devuelto nombre_Metodo (parametros) { Cuerpo del metodo}

*/
using System;

namespace _9._METODOS_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUMA DE DOS NUMEROS USANDO FUNCION");
            Console.WriteLine("Ingrese el primer valor");
            var nro1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor");
            var nro2 = int.Parse(Console.ReadLine());
            
            var resultado = sumaNumeros(nro1, nro2);
            Console.WriteLine($"La suma de los dos numeros es: {resultado}");
            Console.WriteLine("");

            Console.WriteLine("SUMA DE DOS NUMEROS USANDO PROCEDIMIENTO");
            sumaNumeros();
        }

        // ----------------------
        // Funcion: Retorna valor
        // ----------------------
        static int sumaNumeros(int nro1, int nro2)
        {
            int resultado = nro1 + nro2; 
            return resultado;
        }
    
        // -----------------------------------------------------
        // Procedimiento: Corresponde a un void y NUNCA RETORNA
        // -----------------------------------------------------
        static void sumaNumeros()
        {
            int num_1 = 7;
            int num_2 = 9;
            int resultado = num_1 + num_2;
            System.Console.WriteLine(resultado);
        }
    }
}
