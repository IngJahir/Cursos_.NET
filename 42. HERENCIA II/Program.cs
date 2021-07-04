using System;
/*
-----------------------------------------------
VIDEO 42: HERENCIA II: Sintaxis y clase Object
-----------------------------------------------
-> Clase Object: Es la clase de mayor jerarquia y se encuentra en la cuspide; esta se denomina "super clase cosmica". Implicitamente los metodos que pertenecen la "Super clase" son 
                 heredados por las otras clases.
-> Ver mayor informacion en: https://docs.microsoft.com/es-es/dotnet/api/system.object?view=net-5.0
*/
namespace _42._HERENCIA_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo();
            Humano Jahir = new Humano();
            Gorila Copito = new Gorila();

            Copito.trepar();
        }
    }

    // Object en este caso es redundante, se puede omitir
    class Mamiferos : Object
    {
        public void respirar()
        {
            System.Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            System.Console.WriteLine("Cuido de mis crias hasta que sean autonomas");
        }

    }

    class Caballo : Mamiferos
    {
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
