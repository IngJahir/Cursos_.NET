namespace INTERFACES_I.Clases
{
    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        { }

        public void Nadar()
        {
            System.Console.WriteLine($"Soy capaz de nadar");
        }
    }
}
