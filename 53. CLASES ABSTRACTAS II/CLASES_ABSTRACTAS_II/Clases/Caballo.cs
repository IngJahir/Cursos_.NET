namespace CLASES_ABSTRACTAS_II.Clases
{
    using System;

    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        { }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int numeroPatas() => 4;
    }
}
