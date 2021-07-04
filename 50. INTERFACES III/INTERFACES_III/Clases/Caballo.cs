namespace INTERFACES_III.Clases
{
    using System;

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        { }

        public bool esOlimpico() => true;

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        // ---------------------------------------------------------------------------------------------------------------------
        // Forma de solucionar la ambiguedad para especificar el metodo de IAnimalesYDeportes, ISaltoConPatas. Quitar Public !!!
        // ---------------------------------------------------------------------------------------------------------------------
        int IMamiferosTerrestres.numeroPatas() => 4;

        int ISaltoConPatas.numeroPatas() => 2;

        public string tipoDeporte() => "Hipica";
    }
}
