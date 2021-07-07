/*
---------------
VIDEO 58: ENUM 
---------------
-> Enum o tipos enumerados:
    * Son un conjunto de constantes con nombre
    * Sintaxis: enum NombreDeEnumeracion {nombre1, nombre2, nombre3 } 
    * Sirven para representar y manejar valores fijos (Constantes) en un programa
    * Se localizan habitualmente dentro del namespace
*/

using System;

namespace ENUM
{
    // Declacion del Enum
    // ------------------
    enum Estaciones {Primavera, Verano, Otoño, Invierno};
    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 3000}

    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ---------
            // Ejemplo 1
            // ---------

            // Lista enumerada con valores nulos. Usar el signo ?
            // --------------------------------------------------
            Estaciones? oContinente = null;

            // Uso de enum
            // ------------
            Estaciones oPais = Estaciones.Invierno; 
            Console.WriteLine(oPais);

            // Caso para cambiar el contenido de enum
            // --------------------------------------
            string oCiudad = Estaciones.Primavera.ToString();
            Console.WriteLine(oCiudad);
            */

            /*
            // ---------
            // Ejemplo 2
            // ---------

            // Almacenamiento del valor y operaciones
            Bonus Antonio = Bonus.Bueno;         
            double bonusAntonio = (double)Antonio;
            double salarioAntonio = 1500 + bonusAntonio;
            Console.WriteLine(Antonio);
            */

            // ---------
            // Ejemplo 3
            // ---------
            Empleado oEmpleado = new Empleado(Bonus.Extra, 1900.50);
            Console.WriteLine($"El salario del empleado es: {oEmpleado.getSalario()}");
        }
    }
    class Empleado 
    {
        private double salario;
        private Bonus bonusEmpleado;

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonusEmpleado = bonusEmpleado;
            this.salario = salario;
        }

        public double getSalario() => salario + (double)bonusEmpleado;
    }
}
