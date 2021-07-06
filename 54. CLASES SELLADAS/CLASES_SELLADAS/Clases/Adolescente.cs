using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES_SELLADAS.Clases
{
    class Adolescente:Humano
    {
        public Adolescente(string nombreAdolescente):base(nombreAdolescente)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar con clarida");
        }
    }
}
