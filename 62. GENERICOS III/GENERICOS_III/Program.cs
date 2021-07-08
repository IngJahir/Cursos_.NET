/*
---------------------------------------
VIDEO 62: GENERICOS III: Restricciones
---------------------------------------
-> Ejemplo de clase generica con restriccion de clases

*/
namespace GENERICOS_III
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> oDirectores = new AlmacenEmpleados<Director>(3);
            oDirectores.agregar(new Director(1000));
            oDirectores.agregar(new Director(1500));
            oDirectores.agregar(new Director(2500));

            AlmacenEmpleados<Secretaria> oSecretarias = new AlmacenEmpleados<Secretaria>(3);
            oSecretarias.agregar(new Secretaria(1000));
            oSecretarias.agregar(new Secretaria(1500));
            oSecretarias.agregar(new Secretaria(2500));

            // En este caso se genera un error ya que la clase estudiante no implemente la interfaz IEmpleado
            // -----------------------------------------------------------------------------------------------
            /*
            AlmacenEmpleados<Estudiante> oEstudiantes = new AlmacenEmpleados<Estudiante>(3);
            oEstudiantes.agregar(new Estudiante(1000));
            oEstudiantes.agregar(new Estudiante(1500));
            oEstudiantes.agregar(new Estudiante(2500));
            */
        }
    }
}
