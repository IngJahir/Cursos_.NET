using System;

namespace _33._POO_VII
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // El metodo distancia recibe un objeto de tipo Punto
        // ---------------------------------------------------
        public double distancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
    }
}