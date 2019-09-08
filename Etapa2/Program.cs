using System;
using Etapa2.Entidades;

namespace Etapa2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Utmart", 2008, TiposEscuela.Universidad, ciudad: "Soto La Marina", pais: "mexico");

            var arregloCursos = new Curso[3];
            
            arregloCursos[0] = new Curso 
            {
                nombre = "Desarrollo Web"
            };

            arregloCursos[1] = new Curso 
            {
                nombre = "Git hub"
            };

            arregloCursos[2] = new Curso 
            {
                nombre = "Matematicas Aplicadas"
            };

            Console.WriteLine(escuela);  
            Console.WriteLine("===================");
            ImprimirCursos(arregloCursos);

            Console.ReadKey();
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int contador = 0;

            while(contador < arregloCursos.Length)
            {
                 Console.WriteLine($"Nombre: {arregloCursos[contador].nombre}, Id: {arregloCursos[contador].uniqueId} ");
                 //contador = contador + 1;
                 //ontador =+ 1;
                 contador++;

            }
        }
    }
}
