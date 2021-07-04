namespace INTERFACES_II.Clases
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

        // ------------------------------------------------------------------------------------------------------------------------
        // En este caso hay ambiguedad puesto que el nombre del metodo numeroPatas coincide para IAnimalesYDeportes, ISaltoConPatas
        // ------------------------------------------------------------------------------------------------------------------------
        public int numeroPatas() => 4;

        public string tipoDeporte() => "Hipica";
    }
}
