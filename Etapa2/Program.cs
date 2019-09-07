using System;
using Etapa2.Entidades;

namespace Etapa2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Utmart", 2008, TiposEscuela.Universidad, ciudad: "Soto La Marina", pais: "mexico");

            var curso1 = new Curso(){
                nombre = "Desarrollo Web"
            };

            var curso2 = new Curso(){
                nombre = "Git hub"
            };

            var curso3 = new Curso(){
                nombre = "Matematicas Aplicadas"
            };

            Console.WriteLine(escuela);  
            Console.WriteLine("===================");
            Console.WriteLine(curso1.nombre +", "+ curso1.uniqueId);
            Console.WriteLine($"{curso2.nombre}, {curso2.uniqueId}");
            Console.WriteLine(curso3);

            Console.ReadKey();
        }
    }
}
