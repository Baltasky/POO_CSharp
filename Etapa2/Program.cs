using System;
using Etapa2.Entidades;
using static System.Console;

namespace Etapa2 {
    class Program {
        static void Main (string[] args) {
            var escuela = new Escuela("Utmart", 2008, TiposEscuela.Universidad, ciudad: "Soto La Marina", pais: "Mexico");
           /* 
                var arregloCursos = new Curso[3] {
                new Curso () {nombre = "Desarrollo Web"}, 
                new Curso {nombre = "Github"},
                new Curso {nombre = "Matematicas Aplicadas"}
            }; 
            */ 
             escuela.Cursos = new Curso[]{
                new Curso () {nombre = "Desarrollo Web"}, 
                new Curso {nombre = "Github"},
                new Curso {nombre = "Matematicas Aplicadas"}
            }; 

            ImprimirCursosEscuela(escuela);
           /*
           Console.WriteLine (escuela);
            Console.WriteLine ("\n=================WHILE=================");
            ImprimirCursosWhie (arregloCursos);

            Console.WriteLine ("\n=================D0_WHILE==================");
            ImprimirCursosDoWhie (arregloCursos);

            Console.WriteLine ("\n=================FOR==================");
            ImprimirCursosFor (arregloCursos);

            Console.WriteLine ("\n=================FOREACH==================");
            ImprimirCursosForEach (arregloCursos);
            */
            ReadKey ();
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("==============================");
            WriteLine("=====Cursos de la Escuela=====");
            WriteLine("==============================");

            if(escuela?.Cursos != null)//? no va a verificar cursos almenos que la escuela sea direfente de null
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine ($" Nombre: {curso.nombre}, Id: {curso.uniqueId} ");
                }
            }
            
        }
        /* 
        private static void ImprimirCursosWhie (Curso[] arregloCursos) {
            int contador = 0;

            while (contador < arregloCursos.Length) {
                Console.WriteLine ($"Nombre: {arregloCursos[contador].nombre}, Id: {arregloCursos[contador].uniqueId} ");
                //contador = contador + 1;
                //ontador =+ 1;
                contador++;
            }
        }

        private static void ImprimirCursosDoWhie (Curso[] arregloCursos) {
            int contador = 0;

            do {
                Console.WriteLine ($"Nombre: {arregloCursos[contador].nombre}, Id: {arregloCursos[contador].uniqueId} ");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor (Curso[] arregloCursos) {
            for (int I = 0; I < arregloCursos.Length; I++) {
                Console.WriteLine ($"Nombre: {arregloCursos[I].nombre}, Id: {arregloCursos[I].uniqueId} ");
            }
        }

        private static void ImprimirCursosForEach (Curso[] arregloCursos) {
            foreach (var Curso in arregloCursos) {
                Console.WriteLine ($"Nombre: {Curso.nombre}, Id: {Curso.uniqueId} ");
            }
        }
        */
    }
}