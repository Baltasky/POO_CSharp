using System;


namespace Etapa2.Entidades
{
    class Escuela
    {
        //propfull crea una propiedad de forma completa
        string nombre;
        public string Nombre{
            get{ return nombre;}
            set{ nombre = value.ToUpper();}
        }

        //prop atajo para escribir una propiedad de forma corta
        public int añoDeCreacion { get; set;}
        public string pais { get; set; }
        public string ciudad { get; set; }
        public TiposEscuela tipoEscuela { get; set; }

        /*public Escuela(string nombre, int año)
        { 
            Nombre = nombre;
            añoDeCreacion = año;
        } */

        //Forma anidada 
        public Escuela(string nombre, int año) => (Nombre, añoDeCreacion) = (nombre, año);

        public Curso[] Cursos { get; set; }

        //Firma del metodo: que valor retorna, el nombre del metodo y que parametros recibe 
        public Escuela(string nombre, 
        int año, 
        TiposEscuela tipo,
        string pais ="", string ciudad ="") //Estos son parametros opcionales
        {
            (Nombre, añoDeCreacion) = (nombre, año);
            tipoEscuela = tipo;
            this.pais = pais;
            this.ciudad = ciudad;

        }

         public override string ToString()
        {
            return $"Nombre: \"{Nombre}\" \nTipo: {tipoEscuela} \nPais: {pais} \nCiudad: {ciudad} ";
        } 
        //Estas son unas comillas \" que tiene que dibujar y no que cierre la cadena
    } 
}