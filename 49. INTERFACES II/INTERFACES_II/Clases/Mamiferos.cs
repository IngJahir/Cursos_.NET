namespace INTERFACES_II.Clases
{
    using System;

    class Mamiferos
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
}
