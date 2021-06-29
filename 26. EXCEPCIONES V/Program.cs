/*
---------------------------------
VIDEO 26: EXCEPCIONES V: Finally
---------------------------------
-> Finally: Aseguramos que se ejecuta lo que esta adentro de finally se ejecua tanto si el codigo del       
            try se ejecuta como si se ejecuta el de catch. Se utiliza con bases de datos y lectura de ficheros.
   Ademas se utiliza para liberar recursos del sistema.
*/
using System;
using System.IO;

namespace _26._EXCEPCIONES_V
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\Jahir Tautiva\Documents\GitHub\Cursos_.NET\26. EXCEPCIONES V\Documento.txt";
                archivo = new StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error con la lectura del archivo: " + ex.Message);
            }
            // Se cierra el archivo
            // --------------------
            finally
            {
                if (archivo != null)
                    archivo.Close();

                Console.WriteLine("Conexion con el fichero cerrada");
            }
        }
    }
}
