/*
---------------------
VIDEO 13: METODOS V
---------------------
-> Metodos con parametros opcionales: Se debe asignar en la zona de parametros un valor por defecto;
                                      con esto se logra una sobrecarga sin repetir el metodo. 
*/

using System;

namespace _13._METODOS_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PARAMETROS OPCIONALES");
            int val_1 = 2;
            double val_2 = 5;
            double val_3 = 3.5;
            var caso_1 = Suma(val_1, val_2);
            var caso_2 = Suma(val_1, val_2, val_3);
            Console.WriteLine($"Suma para el caso 1: {caso_1}");
            Console.WriteLine($"Suma para el caso 2: {caso_2}");
        }

        // ----------------------------------------------------------------------------------
        // Parametros opcionales: Primero se escriben los obligatorios y luego los opcionales
        // ----------------------------------------------------------------------------------
        private static object Suma(int v1, double v2, double v3 = 0) => v1 + v2 + v3;
    }
}
