using System;

namespace Escuela
{

    class Program
    {
        static void Main(string[] args)
        {
  
        var E1 = new School();
        E1.nombre = "Utmart";
        E1.ceo = "Toño Garza de Yta";
        E1.direccion = "La Pesca, STL. Km 51";
        E1.añoFundacuion = 2008;
        Console.WriteLine("Timbrar: ");
        E1.tocarTimbre();

        Console.WriteLine("Pulse una tecla");
        Console.ReadKey();       
        }
    }
}
