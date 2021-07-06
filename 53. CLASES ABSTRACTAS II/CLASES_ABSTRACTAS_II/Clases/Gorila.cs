namespace CLASES_ABSTRACTAS_II.Clases
{
    using System;

    class Gorila : Mamiferos, IMamiferosTerrestres
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

        public int numeroPatas() => 2;
    }
}
