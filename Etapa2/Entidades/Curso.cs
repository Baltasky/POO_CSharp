using System;

namespace Etapa2.Entidades
{
    public class Curso
    {
        public string uniqueId { get; private set; }

        public string nombre { get; set; }

        public string jornada { get; set; }

        public Curso() => uniqueId = Guid.NewGuid().ToString();
        
    }
}