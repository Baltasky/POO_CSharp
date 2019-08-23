using System;
using Etapa1.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Utmart", 2008, TiposEscuela.Universidad, ciudad: "Soto La Marina", pais: "mexico");

            Console.WriteLine(escuela);
            
            Console.ReadKey();
        }
    }
}
