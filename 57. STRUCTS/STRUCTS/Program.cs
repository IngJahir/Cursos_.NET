/*
------------------
VIDEO 57: STRUCTS 
------------------
-> Memoria Stack: 
    * Memoria de acceso rapido
    * Memoria de almacenamiento temporal
    * Se almacena la informacion en forma de pila
    * LIFO: Last Int First Out
   
-> Memoria Heap: 
    * Memoria de acceso un poco mas lenta.
    * La memoria esta disponible durante toda la ejecion del programa

-> Struct: 
    * Se almacenan en la memoria Stack (Valor).
    * La estructura original queda inalterable.
    * Los cambios solo repercuten en la copia.
    * No permiten la declaracio de constructor por defecto
    * El compilar no inicia los campos. Puede iniciarlos en el constructor
    * No puede haber sobrecarga de constructores
    * No heredan de otras clases pero si implementan interfaces
    * Son selladas.
    
-> Cuando usar struct
    * Cuando se necesita trabajar con una cantidad elevada de datos en memoria (Representacion de primitivos, 
      numeros complejos, puntos tridimensionales, etc)
    * Cuando las instancias no deban cambiar (inmutable).
    * Cuando la instancia tenga tamaño inferior a 16 bytes
    * Cuando no se necesite convertir a objeto(boxed)
    * Por razones de rendimiento
    
-> Clases: 
    * Se almacenan en la memoria Heap (Referencia)
    * Los cambios hechos en el instanciamiento repercuten en el Heap 
    
*/
using System;

namespace STRUCTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado oEmpleado = new Empleado(1200, 250);
            oEmpleado.cambiaSalario(oEmpleado, 500);
            Console.WriteLine(oEmpleado);
        }
    }

    public struct Empleado 
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comision del empleado {0},{1}", this.salarioBase, this.comision);
        }

        public void cambiaSalario(Empleado emp, double incremento) 
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
}
