/*
------------------------------------------------
VIDEO 44: HERENCIA IV: Principio de sustitucion
------------------------------------------------
-> Principio de sustitucion: Consiste en sustituir un objeto de un tipo por un objeto de un tipo diferente teniendo en cuenta la jerarquia de herencia.
-> La frase base es: "es siempre un"
    * Un caballo es siempre un humano? No, por lo tanto no hay herencia
    * Un mamifero es siempre un caballo? No, un mamifero puede ser un humano, un gorila...
    * Un caballo es siempre un mamifero? Si, Por lo tanto la clase mamifero esta por encima de la clase caballo
      Mamiferos animal = new Caballo()

-> Ejemplo de jerrarquia de herencia
    * Empleado
        * Director general
        * Secreatria
        * Jefe de seccion
*/

using System;

namespace _44._HERENCIA_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------
            // Principio de sustutucion: "Es siempre un"
            // ----------------------------------------
            // Nota: Al sustituir solo tengo acceso a los metodos de Mamiferos no a los de caballo, Humano o Gorila !!!!
            Mamiferos oCaballo_1 = new Caballo("Polo");
            Mamiferos oPersona_1 = new Humano("Pepito");
            Mamiferos oGorila_1 = new Gorila("Chita");

            // ---------------------------
            // Alternativa de sustitucion
            // ---------------------------
            Mamiferos oAnimal = new Mamiferos("Alvarito");
            Caballo oCaballo_2 = new Caballo("Alvarito");
            oAnimal = oCaballo_2;

            // -----------------------------------------------------------------------------
            // Aplicacion de la sustitucion: Almacenamiento de objetos de diferentes clases 
            // -----------------------------------------------------------------------------
            // Nota: Al sustituir solo tengo acceso a los metodos de Mamiferos no a los de caballo, Humano o Gorila !!!!
            Caballo oCaballo = new Caballo("Babieca");
            Humano oHumano = new Humano("Jahir");
            Gorila oGorila = new Gorila("Copito");
            Mamiferos[] listaMamiferos = new Mamiferos[3]
            listaMamiferos[0] = oCaballo;
            listaMamiferos[1] = oHumano;
            listaMamiferos[1] = oGorila;

            // ---------------------------------
            // Ejemplo de sustitucion con object
            // ---------------------------------
            Object oAnimal_ob = new Caballo("Corcel");
            Object oPersona_ob = new Humano("Jairo");
            Object oMamifero_ob = new Gorila("Piter");
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
