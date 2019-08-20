using System;
using Etapa1.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Utmart", 2008);
            escuela.pais = "México";

            Console.WriteLine(escuela.Nombre);
            
            Console.ReadKey();
        }
    }
}
