/*
----------------------------------------
VIDEO 67: DELEGADOS_PREDICADOS_LAMBDA I
----------------------------------------
-> DELEGADOS:
    * Funciones que delegan tareas en otras funciones
    * Muy similares a los apuntdores de C++
    * Un delegado es un referente a un metodo
    * Se usan para llamado de eventos
    * Reduce significativamente el codigo al manejar diferentes escenarios
    * Codigo muy reutilizable
    
-> Sintaxis: delegate tipo NombreDelegado(argumentos);
*/
using System;

namespace DELEGADOS_PREDICADOS_LAMBDA_I
{
    class Program
    {
        // Definicion del objeto delegado
        // -------------------------------
        delegate void ObjetoDelegado(string msj);

        static void Main(string[] args)
        {

            // Creacion del objeto delegado apuntando a mensaje bienvenida
            // ------------------------------------------------------------
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvedina);
            
            // Utilizacion del objeto para llamar al metodo saludoBienvenida
            // --------------------------------------------------------------
            ElDelegado("Hola !!! Acabo de llegar");

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado("Hola !!! Ya me voy");
        }
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvedina(string msj) 
        {
            Console.WriteLine($"Mensaje de bienvenida: {msj}");
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Mensaje de despedida: {msj}");
        }
    }
}
