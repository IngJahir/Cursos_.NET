using System;
using System.Collections.Generic;
using System.Text;


namespace CLASES_SELLADAS.Clases
{
    // Generar error por que Gorila es un clase sellada
    // ------------------------------------------------
    class Chimpance : Gorila
    {
        public Chimpance(string nombreChimpance) : base(nombreChimpance)
        {

        }
    }
}
