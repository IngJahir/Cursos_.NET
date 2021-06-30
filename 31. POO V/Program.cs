/*
----------------------------------
VIDEO 31: POO V: Gettes y Setters
----------------------------------
-> Setter: Establece propiedades en los objetos.
-> Uso del this.
-> Dividir la clase en trozos
*/
using System;

namespace _31._POO_V
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

            // Uso del segundo constructor
            // -----------------------------
            Console.WriteLine("CASO COCHE 3");
            Coche coche_3 = new Coche();
            coche_3.setExtras(true, "Cuero");
            Console.WriteLine(coche_3.infoCoche());
            Console.WriteLine(coche_3.getExtras());
            Console.WriteLine($"El numero de ruedas es: {coche_3.getRuedas()}");
            Console.WriteLine("");
        }
    }

    /*
    // -------------------------
    // Caso 1: Clase sin dividir
    // -------------------------
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
            tapiceria = "Tela";
        }
        // Sobrecarga del constructor
        // --------------------------
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }

        public string infoCoche()
        {
            return $"Informacion del coche: Largo: {largo}, Ancho: {ancho}, Ruedas {ruedas}";
        }

        // Getters
        // -------
        public int getRuedas() => ruedas;
        public double getLargo() => largo;
        public double getAncho() => ancho;
        public string getExtras() => $"Extras del coche: Climatizador: {climatizador}, Tapiceria: {tapiceria}";

        // Setters
        // -------
        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
    }
    */

    // -----------------------
    // Caso 2: Clase dividida
    // -----------------------

    // Primera parte de la clase
    // -------------------------
    partial class Coche
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
            tapiceria = "Tela";
        }
        // Sobrecarga del constructor
        // --------------------------
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
    }

    // Seunda parte de la clase
    // -------------------------
    partial class Coche
    {
        public string infoCoche()
        {
            return $"Informacion del coche: Largo: {largo}, Ancho: {ancho}, Ruedas {ruedas}";
        }

        // Getters
        // -------
        public int getRuedas() => ruedas;
        public double getLargo() => largo;
        public double getAncho() => ancho;
        public string getExtras() => $"Extras del coche: Climatizador: {climatizador}, Tapiceria: {tapiceria}";

        // Setters
        // -------
        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
    }
}
