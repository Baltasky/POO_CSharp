using System;
using static System.Console;

namespace Condiciones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rta= 10 == 10;
            int cantidad = 10;
            
            if (rta == false)
            {
                WriteLine("Se cumplio la condición #1"); //hago algo
            }
            else if (cantidad > 15)
            {
                WriteLine("Se cumplio la condición #2");//hago otra cosa
            }
            else
            {
                WriteLine("No se cumplio la condición ");//hacer otra cosa si no se cumple
            }

            if (cantidad > 5 && rta == false)
            {
                WriteLine("Se cumplio la condición #3");
            }

            if (cantidad > 5 && rta)
            {
                WriteLine("Se cumplio la condición #4");
            }
        
            if ((cantidad > 5 || !rta) && (cantidad % 5 == 0))//! sirve para negar
            {
                WriteLine("Se cumplio la condición #5");
            }


            Console.ReadKey();

        }
    }
}
