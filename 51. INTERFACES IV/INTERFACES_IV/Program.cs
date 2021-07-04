/*
-------------------------
VIDEO 51: INTERFACES IV:
------------------------
-> Ejemplo sencillo.

*/
using System;

namespace INTERFACES_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------
            // Aviso en caso generico
            // ----------------------
            Console.WriteLine("Aviso generico");
            AvisosTrafico oAviso_1 = new AvisosTrafico();
            oAviso_1.mostrarAviso();
            Console.WriteLine("");

            // --------------------
            // Aviso personalizado
            // --------------------
            Console.WriteLine("Aviso personalizado");
            AvisosTrafico oAviso_2 = new AvisosTrafico("Jefatura Provincial de Madrid", "Sancion de velocidad: 300$", "02-05-2021");
            Console.WriteLine($"Fecha: {oAviso_2.getFecha()}");
            oAviso_2.mostrarAviso();
        }
    }
}
