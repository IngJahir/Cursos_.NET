/*
-------------------------------
VIDEO 30: POO IV: Constructores
-------------------------------
-> Constructores: Tienen como finalidad dar un estado inicial a los objetos
-> Sobrecarga de copnstructores: Creacion de mas de un constructores
-> Constructor por defecto: Contructor no escrito, pero esta presente por defecto y esta vacio
*/
using System;

namespace _30._POO_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso del primer constructor
            // -----------------------------
            Console.WriteLine("CASO COCHE 1");
            Coche coche_1 = new Coche();
            Console.WriteLine(coche_1.infoCoche());
            Console.WriteLine($"El numero de ruedas es: {coche_1.getRuedas()}");
            Console.WriteLine("");

            // Uso del segundo constructor
            // -----------------------------
            Console.WriteLine("CASO COCHE 2");
            Coche coche_2 = new Coche(4500.25, 1200.35);
            Console.WriteLine(coche_2.infoCoche());
            Console.WriteLine($"El numero de ruedas es: {coche_1.getRuedas()}");
            Console.WriteLine("");
        }
    }
    class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

        // Constructor base
        // ----------------
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.8;
        }
        // Sobrecarga del constructor
        // --------------------------
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        public string infoCoche()
        {
            return $"Informacion del coche: Largo: {largo}, Ancho: {ancho}, Ruedas {ruedas}";
        }

        public int getRuedas() => ruedas;
        public double getLargo() => largo;
        public double getAncho() => ancho;
    }
}
