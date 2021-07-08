/*
---------------------
VIDEO 60: GENERICOS I
---------------------
-> Programacion generica:
    * Se utilizan para reutilizar codigo
    * Sintaxis: EjemploClase <String> archivos = new EjemploClase <String>()
                EjemploClase <File> archivos = new EjemploClase <File>()
-> Por que utilizarla
    * Mayor sencillez del codigo
    * Reutilizacion de codigo en numerosos escenarios
    * Comprobacion de errores en tiempo de compilacion
-> 
*/

using System;

namespace GENERICOS_I
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ----------
            // Ejemplo 1:
            // ----------
            AlmacenoObjetos oArchivo = new AlmacenoObjetos(4);
            oArchivo.agregar("Juan");
            oArchivo.agregar("Helena");
            oArchivo.agregar("Antonio");
            oArchivo.agregar("Sara");

            String nombrePersona = (string)oArchivo.getObjeto(1);
            Console.WriteLine(nombrePersona);
            */

            // ----------
            // Ejemplo 2:
            // ----------
            // En este caso es necesario el uso de casteo de variables !!!
            // ------------------------------------------------------------
            AlmacenoObjetos oArchivo = new AlmacenoObjetos(4);
            oArchivo.agregar(new Empleado(1500));
            oArchivo.agregar(new Empleado(2500));
            oArchivo.agregar(new Empleado(3500)); 
            oArchivo.agregar(new Empleado(4500));

            Empleado salarioEmpleado = (Empleado)oArchivo.getObjeto(2);
            Console.WriteLine(salarioEmpleado.getSalario());

        }
    }

    class AlmacenoObjetos 
    {
        private Object[] datosElemento;
        private int i = 0;

        public AlmacenoObjetos(int z)
        {
            datosElemento = new Object[z];
        }

        public void agregar(Object obj) 
        {
            datosElemento[i] = obj;
            i++;
        }

        public Object getObjeto(int i) => datosElemento[i];
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
