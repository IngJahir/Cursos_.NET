using System;

namespace _32._POO_VI
{
    public class Punto
    {
        public Punto()
        {
            Console.WriteLine("Constructor por defecto");
        }
        public Punto(int x, int y)
        {
            Console.WriteLine($"Cordenada x:{x} ");
            Console.WriteLine($"Cordenada x:{y} ");
        }
    }
}