/*
--------------------------------------------
VIDEO 48: INTERFACES I: Conceptos generales
-------------------------------------------
-> Intrefaces o plantillas: Conjunto de directrices que deben cumplir las clases
-> Implementar una interfaz es heredar dicha interfaz
-> La interfaz debe cumplir los siguientes lineamientos:
    * El nombre del metodo debe coincidir con el de la interfaz
    * Debe devolver el mismo tipo de datos
    * Debe coincidir el numero de parametros
*/
namespace INTERFACES_I
{
    using INTERFACES_I.Clases;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CABALLO");
            Caballo oCaballo = new Caballo("Babieta");
            Console.WriteLine($"El numero de patas de Babieta es: {oCaballo.numeroPatas()}");
            Console.WriteLine("");

            Console.WriteLine("BALLENA");
            Ballena oBallena = new Ballena("Wally");
            oBallena.Nadar();
        }
    }
}
