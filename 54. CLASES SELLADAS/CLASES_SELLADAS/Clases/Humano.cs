namespace CLASES_SELLADAS.Clases
{
    using System;

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        { }

        // -------------------------------------------------------------------------------
        // Override: Se escribe ya que se esta modificando el metodo "pensar" de Mamiferos
        // -------------------------------------------------------------------------------
        public sealed override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
}
