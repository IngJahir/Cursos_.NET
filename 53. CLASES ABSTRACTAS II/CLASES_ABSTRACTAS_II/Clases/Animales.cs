using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES_ABSTRACTAS_II.Clases
{
    abstract class Animales
    {
        public void respirar() 
        {
            Console.WriteLine("Soy capz de respirar");
        }

        // Con esta forma de declaracion cada clase esten obligadas a desarrollar este metodo
        // ----------------------------------------------------------------------------------
        public abstract void getNombre();
    }
}
