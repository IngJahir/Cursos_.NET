using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES_SELLADAS.Clases
{
    class Lagartija : Animales
    {
        string nombreReptil;
        
        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }
        
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreReptil}");
        }
    }
}
