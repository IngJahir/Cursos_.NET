namespace _47._HERENCIA_VII
{
    public class Vehiculo
    {
        public void ArrancarMotor(string sonidoAlArrancar)
        {
            System.Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
        }

        public void PararMotor(string sonidoAlParar)
        {
            System.Console.WriteLine($"Arranca el motor: {sonidoAlParar}");
        }

        public virtual void Conducir()
        {
            System.Console.WriteLine($"Este es el codigo generico para el metodo conducir");
        }
    }
}