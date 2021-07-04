/*
-------------------------
VIDEO 50: INTERFACES III:
------------------------
-> Para solucinar la ambigüedad cuando en dos o mas interfaces en la que aparece el mismo nombre del metodo, se usa el principio de sustitucion "es-un".

-> Restricciones para interfaces:
    * No se permite definir campos (Variables) en interfaces
    * No se pueden definir constructores
    * No se pueden definir destructores
    * No se pueden especificar modificadores de acceso en metodos(Todos son publicos de forma implicita)
    * No se pueden anidar clases ni otro tipo de estructuras en las interfaces.
*/
namespace INTERFACES_III
{
    using INTERFACES_III.Clases;
    using System; 
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Uso de principio de sustitucion
            // -------------------------------
            Console.WriteLine("CABALLO");
            Caballo oCaballo = new Caballo("Babieta");
            IMamiferosTerrestres iCaballo_mamifero = oCaballo;
            ISaltoConPatas iSalto = oCaballo; 
            Console.WriteLine($"El numero de patas de Babieta es: {iCaballo_mamifero.numeroPatas()}");
            Console.WriteLine($"El numero de patas para saltar es: {iSalto.numeroPatas()}");
            Console.WriteLine("");
        }
    }
}
