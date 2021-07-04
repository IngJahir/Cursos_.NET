/*
-----------------------------------
VIDEO 45: HERENCIA V: Polimorfismo
-----------------------------------
-> Polimorfismo
-> Palabras reservadas
    * New
    * Virtual
    * Override
*/
using System;

namespace _45._HERENCIA_V
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Aplicacion de la sustitucion: Almacenamiento de objetos de diferentes clases 
            // -----------------------------------------------------------------------------
            // Nota: Al sustituir solo tengo acceso a los metodos de Mamiferos no a los de caballo, Humano o Gorila !!!!
            Caballo oCaballo = new Caballo("Babieca");
            Humano oHumano = new Humano("Jahir");
            Gorila oGorila = new Gorila("Copito");
            Mamiferos[] listaMamiferos = new Mamiferos[3];
            listaMamiferos[0] = oCaballo;
            listaMamiferos[1] = oHumano;
            listaMamiferos[2] = oGorila;

            // ------------
            // Polimorfismo
            // ------------
            for (var i = 0; i < listaMamiferos.Length; i++)
            {
                listaMamiferos[i].pensar();
            }

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

            // -------------------------------------------------------------------------------------------------------
            // virtual: Indica que TODAS las subclases de Mamiferos deberian tener un metodo "pensar" que modifica el metodo
            //          "pensar" de Mamiferos Las nuevas clases pensar llevan la palabra override
            // ---------------------------------------------------------------------------------------------------           
            public virtual void pensar()
            {
                Console.WriteLine("Pensamiento basico instintivo");
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

            // -------------------------------------------------------------------------------
            // Override: Se escribe ya que se esta modificando el metodo "pensar" de Mamiferos
            // -------------------------------------------------------------------------------
            public override void pensar()
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

            // -------------------------------------------------------------------------------
            // Override: Se escribe ya que se esta modificando el metodo "pensar" de Mamiferos
            // -------------------------------------------------------------------------------
            public override void pensar()
            {
                Console.WriteLine("Pensamiento instintivo avanzado");
            }
        }
    }
}
