/*
-------------------------
VIDEO 49: INTERFACES II:
------------------------
-> 
*/
namespace INTERFACES_II
{
    using INTERFACES_II.Clases;
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
