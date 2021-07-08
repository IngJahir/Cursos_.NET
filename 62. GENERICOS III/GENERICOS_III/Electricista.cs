namespace GENERICOS_III
{
    using System;

    class Electricista : IEmpleado
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double getSalario() => salario;
    }
}
