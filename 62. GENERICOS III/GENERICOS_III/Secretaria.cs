namespace GENERICOS_III
{
    using System;

    class Secretaria : IEmpleado
    {
        private double salario;

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario() => salario;
    }
}
