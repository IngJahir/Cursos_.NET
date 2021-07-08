using System;
using System.Collections.Generic;
using System.Text;

namespace GENERICOS_III
{
    class Estudiante
    {
        private double edad;

        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad() => edad; 
    }
}
