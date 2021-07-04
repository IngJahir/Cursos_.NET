/*
---------------------------------------------
VIDEO 43: HERENCIA III: Constructores y base
---------------------------------------------
-> Constructores en superclase y subclase
-> Instruccion base(): Llama el constructor de la superclase o clase padre en las subclases
-> Constructor por defecto: Constructor que no recibe parametro alguno y esta completamente vacio
-> El constructor de la subclase SIEMPRE LLAMA el constructor de la CLASE PADRE y lo hace con la instruccion :base()

-> Mamiferos:
    * Caballo
    * Humano
    * Gorila
*/

using System;

namespace _43._HERENCIA_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo oCaballo = new Caballo("Babieca");
            Humano oHumano = new Humano("Jahir");
            Gorila oGorila = new Gorila("Copito");

            System.Console.WriteLine($"Nombre del caballo: {oCaballo.getNombre()}");
            System.Console.WriteLine($"Nombre de la persona: {oHumano.getNombre()}");

        }

        // Object en este caso es redundante, se puede omitir
        class Mamiferos : Object
        {
            private string nombreSerVivo;

            public Mamiferos(string nombre)
            {
                nombreSerVivo = nombre;
            }

            public void respirar()
            {
                System.Console.WriteLine("Soy capaz de respirar");
            }

            public void cuidarCrias()
            {
                System.Console.WriteLine("Cuido de mis crias hasta que sean autonomas");
            }

            public string getNombre() => nombreSerVivo;
        }

        class Caballo : Mamiferos
        {
            public Caballo(string nombreCaballo) : base(nombreCaballo)
            { }

            public void galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
            }
        }

        class Humano : Mamiferos
        {
            public Humano(string nombreHumano) : base(nombreHumano)
            { }

            public void pensar()
            {
                Console.WriteLine("Soy capaz de pensar");
            }
        }

        class Gorila : Mamiferos
        {
            public Gorila(string nombreGorila) : base(nombreGorila)
            { }

            public void trepar()
            {
                Console.WriteLine("Soy capaz de trepar");
            }
        }
    }
}
