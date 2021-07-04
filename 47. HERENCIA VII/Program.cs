/*
-----------------------------------------
VIDEO 47: HERENCIA VII: Ejercicio guiado
----------------------------------------
-> Public: Accesible desde cualquier clase
-> Protected: Accesible unicamente por la clase que la contiene
-> Protected: Accecible desde la propia clase y de aquellas clases que la hereden
*/
using System;

namespace _47._HERENCIA_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------
            // Utlizando avion
            // ---------------
            Console.WriteLine("Probando el avion");
            Avion oAvion = new Avion();
            oAvion.ArrancarMotor("tra tra tra");
            oAvion.Despegar();
            oAvion.Conducir();
            oAvion.Aterrizar();
            oAvion.PararMotor("Plooof");
            Console.WriteLine("");

            // ---------------
            // Utlizando coche
            // ---------------
            Console.WriteLine("Probando el avion");
            Coche oCoche = new Coche();
            oCoche.ArrancarMotor("run run run");
            oCoche.Acelerar();
            oCoche.Conducir();
            oCoche.Frenar();
            oCoche.PararMotor("bluuuf");
            Console.WriteLine("");

            // ---------------
            // Polimorfismo
            // ---------------
            Console.WriteLine("Uso de polimorfismo");

            Vehiculo oVehiculo = oCoche;
            oVehiculo.Conducir();

            oVehiculo = oAvion;
            oVehiculo.Conducir();
        }
    }
}
