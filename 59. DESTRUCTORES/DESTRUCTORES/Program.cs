/*
----------------------
VIDEO 59: DESTRUCTORES
----------------------

-> Destructores: Ejecutan codigo a la destruccion de un recursos en memoria. Ejemplos:
   - Conexiones con BBDD
   - Cierre de streams en el manejo externo de ficheros
   - Eliminacion de objetos de coleccion

-> A tener en cuenta de los destructores:
    * Solo se usan en clases
    * Cada clase solo puede tener un destructor
    * Los destructores no se heredan ni se sobrecargan
    * Los destructores no se llaman, son invocados automaticamente.
    * Los destructores no tienen modificadores de acceso ni parametros.
*/

namespace DESTRUCTORES
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivo oDocumento = new ManejoArchivo();
            oDocumento.mensaje();
        }
    }

    class ManejoArchivo 
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        // Constructor
        // -----------
        public ManejoArchivo()
        {
            archivo = new StreamReader(@"C:\Projects\PILDORAS\59. DESTRUCTORES\DESTRUCTORES\Documento.txt");

            while ((linea=archivo.ReadLine())!=null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        // Destructor
        // ----------
        ~ManejoArchivo()
        {
            archivo.Close();
        }

        // Metodos
        // --------
        public void mensaje() 
        {
            Console.WriteLine($"Hay {0} lineas", contador);
        }        
    }
}
