/*
---------------------------
VIDEO 4: SINTAXIS BASICA II
---------------------------
-> Tipos de datos:

    ->> Por referencia: Son aquellos que al momento de almancenarlos, se almacena una direccion en la memoria de ese tipo
                        por referencia. En este grupo estan los string.

    ->> Por valor: Son aquellos que maneja el procesador directamente y se almacenan directamente en una variable
      ->>> Estructuras 
      ->>> Enumerados
      ->>> Primitivos:
          + Enteros:
            ++ Con signo: sbyte, short, int, long
            ++ Sin signo: byte, ushort, uinit, ulong. 
          + Reales: Float, double, decimal
          + Boleanos: True, false.
          + UTF16 : Caracteres

-> Resumen de datos:
    TIPO    DESCRIPCION Y TAMAÑO EN BITS
    int     Numeros enteros (32)
    long    Numeros enteros muy grandes (64) 
    float   Numeros decimales (32)
    double  Numeros decimales con parte decimal larga (64)  
    decimal Numeros decimales con parte decimal muy larga (128)
    string  Cadena de caracteres (16 por caracter)
    char    Un unico caracter (16)
    bool    Booleanos (8)

-> Variables: Espacoio de memoria (RAM) del ordenador donde se almacenara un valor que podrá cambiar durante la
             ejecuacion  del programa.

-> Convenciones:
    + No comenzar el nombre de la variable con un guion bajo
    + No crear mas de una variable que se diferencien solo por una letra
    + Comenzar el nombre de las variables con letra minuscula
    + Si el nombre de la variable esta compuesto por mas de una palabra, comenzar la segunda con mayuscula (Camelcase)
    + No utilizar notacion Hungara (iedad -> integer edad)

-> Declaracion de variables:
    + Es crear o construir las variables
    + Para declararlas se debe indicar el tipo de dato que va almacenar en su interior y a continuacion la variable.
      Ejemplo: int edad

-> Iniciar variables:
    + Asignar un variable a la variable, es decir especificar el valor que almacena la variable en su interior. 
      Ejemplo: edad = 28
    + Existe la posibilidad de declarar e iniciar en la misma instruccion. Ejemplo: int edad = 28. 
    + EN C# NO SE PUEDE UTILIZAR UNA VARIABLE QUE NO HA SIDO INICIADA !!!!
*/

using System;

namespace _4._SINTAXIS_BASICA_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion y uso de variables
            int edad = 28;
            Console.WriteLine(edad);
        }
    }
}
