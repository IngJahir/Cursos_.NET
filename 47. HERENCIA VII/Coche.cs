namespace _47._HERENCIA_VII
{
    public class Coche : Vehiculo
    {
        public void Acelerar()
        {
            System.Console.WriteLine($"Acelerando");
        }

        public void Frenar()
        {
            System.Console.WriteLine($"Frenando");
        }

        public override void Conducir()
        {
            System.Console.WriteLine($"Tomando las curvas con precaucion y destreza");
        }

    }
}