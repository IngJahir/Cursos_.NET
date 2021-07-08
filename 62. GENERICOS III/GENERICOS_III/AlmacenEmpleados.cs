using System;
using System.Collections.Generic;
using System.Text;

// Esta clase maneja objetos de diferente tipos por que es generica,
// pero dichos objetos estan OBLIGADOS a implementar la interfaz IEmpleado
// -----------------------------------------------------------------------
namespace GENERICOS_III
{
    class AlmacenEmpleados <T> where T:IEmpleado
    {
        private int i = 0;
        private T[] datosEmpleado;

        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void agregar(T obj) 
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T getEmpleado(int i) => datosEmpleado[i];       
    }
}
