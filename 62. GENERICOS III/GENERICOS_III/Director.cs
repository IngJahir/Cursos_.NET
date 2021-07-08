namespace GENERICOS_III
{
    using System;

    class Director : IEmpleado
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double getSalario() => salario;        
    }
}
