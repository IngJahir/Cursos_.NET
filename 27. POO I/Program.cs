/*
-----------------------------------
VIDEO 27: POO I: Conceptos basicos
-----------------------------------
-> Paradigmas de programacion

    * Programacion orientada a procedimientos (Fortran, Cobol, Basic)
        -> Desvantajas:
            - Unidades de codigo muy grandes en aplicaciones complejas
            - En aplicaciones conplejas el codigo resulta dificil de descifrar
            - Poco reutilizable
            - Si existe un fallo en alguna linea de codigo, es probable que el programa
              caiga
            - Aparcicion frecuente de codigo espagueti
            - Dificil de depurar por otros progamadores en caso de necesidad o error

    * Programacion orientada a objetos (C++, Java, Visual .NET)
        -> Consiste en transladar la naturaleza de los objetos de la vida real al codigo de programacion.

        -> Los onjetos tienen un estado, un comportamiento y unas propiedades

        -> Ejemplo: Objeto coche
            - Estado: Parado, circulando, parqueado
            - Propiedades: Color, peso, tamaño
            - Comportamiento: Arrancar, frenar, acelerar, girar.

        -> Ventajas:
            - Programas divididos en trozos, modulos o clases (Modularizacion)
            - Muy reutilizable (Herancia)
            - Si existe un fallo en alguna linea del codigo, el programa continuara con su funcionamiento. Tratamiento de
              excepciones
            - Encapsulamiento

        -> Modificadores de acceso
            - Public: Accesible desde cualquier parte
            - Private: Accesible desde la propia clase
            - Protected: Accesible desde la clase derivada
            - Internal: Accesible desde el mismo ensamblado
            - Protected internal: Accesible desde el mismo ensamblado o clase derivada de otro ensamble
            - Private protected: Accesible desde la misma clase o clase derivada del mismo ensamblado
            - Por defecto: Accesible desde el mismo paquete
        
        -> Lexico: Clase, objeto, modularizacion, encapsulamiento, herencia, polimorfismo, instanciar o ejemplarizar una    
                   clase.

        -> Clase: Modelo donde se redactan las caracteristicas comunes de un grupo de objetos
        -> Objetos: Ejemplar perteneciente  a una clase
            - Tienen propiedades (Atributos): Color, peso, alto, largo
            - Tienen un comportamiento (metodos o funciones): Arrancar, frenar, girar, acelerar
*/
using System;

namespace _27._POO_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO: PROGRAMCION ORIENTADA A OBJETOS");
        }
    }
}
