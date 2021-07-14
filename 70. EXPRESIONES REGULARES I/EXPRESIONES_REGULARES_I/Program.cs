/*
----------------------------------
VIDEO 70: EXPRESIONES REGULARES I
----------------------------------
-> Expresion regular: Secuencia de caracteres que funcionan como un patron de busqueda.
                      buscan cadenas de caracteres como letras, numeros u otros caracteres.

-> Se utilizan para validacion de formularios, busqueda en ficheros externos, busqueda en BBDD,
   comprobacion de entrada de usuarios.

-> Clase utiles: Regex, Match, MatchCollection, GroupCollection
-> Metodos utiles: Matches
-> Propiedades utiles: Groups
*/
using System;
using System.Text.RegularExpressions;

namespace EXPRESIONES_REGULARES_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y mi numero de telefono es (+34)123-45-67 y mi codigo postal es 29679";
            string patron_1 = "[J]";
            string patron_2 = @"\d"; // Corresponde a los numeros segun la documentacion
            string patron_3 = @"\d{3}-\d{2}-\d{2}"; // Formato de numero de telefono 3-2-2;


            // Creacion de espresion regular
            // -----------------------------
            Regex oRegex_1 = new Regex(patron_1);
            Regex oRegex_2 = new Regex(patron_2);
            Regex oRegex_3 = new Regex(patron_3);

            // Buscar y almacenar las coincidencias
            // ------------------------------------
            MatchCollection oMatch_1 = oRegex_1.Matches(frase);
            MatchCollection oMatch_2 = oRegex_2.Matches(frase);
            MatchCollection oMatch_3 = oRegex_3.Matches(frase);

            // Mensaja de encontrado
            // ---------------------
            if (oMatch_1.Count > 0) Console.WriteLine("Se ha encontrado una J");
            else Console.WriteLine("No se ha encontrado una J");

            if (oMatch_2.Count > 0) Console.WriteLine("Se ha encontrado numeros");
            else Console.WriteLine("No se ha encontrado numeros");

            if (oMatch_3.Count > 0) Console.WriteLine("Se ha encontrado un numero de telefono");
            else Console.WriteLine("No se ha encontrado un numero de telefono");
        }
    }
}
