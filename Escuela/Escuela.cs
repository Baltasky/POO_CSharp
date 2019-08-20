using System;

namespace  Escuela
{
   public class School
    {
       public string nombre;
       public string direccion;
       public string ceo;
       public int añoFundacuion;
       

       public void tocarTimbre()
        {
            Console.Beep(2000,1000); //2000 es la frecuencia del sonido y 1000 es el tiempo 
            Console.Beep(2000,1000);
            Console.Beep(2000,1000);
            Console.Beep(2000,1000);
            Console.Beep(2000,1000);
        }
    }
}