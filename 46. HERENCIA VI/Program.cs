/*
---------------------------------
VIDEO 46: HERENCIA VI: Protected
---------------------------------
-> Public: Accesible desde cualquier clase
-> Protected: Accesible unicamente por la clase que la contiene
-> Protected: Accecible desde la propia clase y de aquellas clases que la hereden
*/

using System;

namespace _46._HERENCIA_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------
            // En este caso no se puede hacer uso de la clase respirar
            // --------------------------------------------------------
            Mamiferos oMamiferos = new Mamiferos("Nombre");
            miMamifero.repirar();
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

        protected void respirar()
        {
            System.Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            System.Console.WriteLine("Cuido de mis crias hasta que sean autonomas");
        }

        // ------------------------------------------------------------------------------------------------------------------------------------
        // virtual: Indica que TODAS las subclases de Mamiferos deberian tener un metodo "pensar" que modifica el metodo "pensar" de Mamiferos
        //          Las nuevas clases pensar llevan la palabra override
        // ------------------------------------------------------------------------------------------------------------------------------------           
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
