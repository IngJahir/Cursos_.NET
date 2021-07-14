/*
-----------------------------------
VIDEO 71: EXPRESIONES REGULARES II
-----------------------------------
-> Usando operador | y cuantificadores
-> Ver generadores de expresiones regulares por internet!!

*/
using System;
using System.Text.RegularExpressions;

namespace EXPRESIONES_REGULARES_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1: Usando el operador o
            // -------------------------------
            string frase = "Mi nombre es Juan y mi numero de telefono es (+34)123-45-67, (+44)321-54-76  y mi codigo postal es 29679";
            string patron_1 = @"\+34|\+44";

            Regex oRegex_1 = new Regex(patron_1);
            MatchCollection oMatch_1 = oRegex_1.Matches(frase);

            if (oMatch_1.Count > 0) Console.WriteLine("Se ha encontrado numero de telefono de UK o de España");
            else Console.WriteLine("No se ha encontrado numero de telefono ni de España ni de UK");

            // Ejemplo 2: Usando una pagina web
            // ---------------------------------
            string web = "Mi web es https://wwww.pildorasinformaticas.es";
            string patron_2 = "https?://(www.)? pildorasinformaticas.es"; // ? Esta una o ninguna
            
            Regex oRegex_2 = new Regex(patron_2);
            MatchCollection oMatch_2 = oRegex_2.Matches(web);

            if (oMatch_2.Count > 0) Console.WriteLine("Se ha encontrado una web");
            else Console.WriteLine("No se ha encontrado ninguna web");

            // Ejemplo 3: Usando un correo electronico
            // ----------------------------------------
            string email = "cursos@pildorasinformaticas.es";
            string re1 = ".*?";
            string re2 = "(@)";
            string re3 = ".*?";
            string re4 = "(\\.)";

            Regex r = new Regex(re1 + re2 + re3 + re4,RegexOptions.IgnoreCase |RegexOptions.Singleline);
            Match m = r.Match(email);
            if (m.Success) Console.WriteLine("Email correcto");
            else Console.WriteLine("Email NO CORECCTO");

        }
    }
}
