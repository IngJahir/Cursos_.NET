namespace _47._HERENCIA_VII
{
    public class Avion : Vehiculo
    {
        public void Despegar()
        {
            System.Console.WriteLine($"Despegando");
        }
        public void Aterrizar()
        {
            System.Console.WriteLine($"Aterrizando");
        }

        public override void Conducir()
        {
            System.Console.WriteLine($"Surcando los cielos del globo");
        }

    }
}