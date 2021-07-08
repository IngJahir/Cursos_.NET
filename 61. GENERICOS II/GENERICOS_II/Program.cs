/*
-----------------------
VIDEO 61: GENERICOS II
-----------------------
-> Con la utilizacion de clases genericas se evita el casteo de variables !!!
*/
using System;

namespace GENERICOS_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ----------
            // Ejemplo 1:
            // ----------
            // En este caso NO SE NECESITA EL CASTEO !!!
            // -----------------------------------------
            AlmacenoObjetos<string> oArchivo = new AlmacenoObjetos<string>(4);
            oArchivo.agregar("Juan");
            oArchivo.agregar("Helena");
            oArchivo.agregar("Antonio");
            oArchivo.agregar("Sara");

            String nombrePersona = oArchivo.getObjeto(1);
            Console.WriteLine(nombrePersona);
            */
            
            // ----------
            // Ejemplo 2:
            // ----------
            // En este caso NO SE NECESITA EL CASTEO !!!
            // -----------------------------------------
            AlmacenoObjetos<Empleado> oArchivo = new AlmacenoObjetos<Empleado>(4);
            oArchivo.agregar(new Empleado(1500));
            oArchivo.agregar(new Empleado(2500));
            oArchivo.agregar(new Empleado(3500));
            oArchivo.agregar(new Empleado(4500));

            Empleado salarioEmpleado = oArchivo.getObjeto(2);
            Console.WriteLine(salarioEmpleado.getSalario());
            
        }
    }

    // La declaracion de clase generica se hace con <T>
    // ------------------------------------------------
    class AlmacenoObjetos<T>
    {
        private T[] datosElemento;
        private int i = 0;

        public AlmacenoObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getObjeto(int i) => datosElemento[i];
    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}
