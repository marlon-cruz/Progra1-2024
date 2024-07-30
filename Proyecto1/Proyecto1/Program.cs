using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control

            //1 if ejercicio.pedir al usuario y si es mayor que nos diga bienvenido

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            if(edad < 0)
            {
                Console.Write("Edad incorrecta");
            }else if (edad <= 2)
            {
                Console.Write("Eres un bebe");
            }else if (edad < 12)
            {
                Console.Write("Eres un niño");
            }else if (edad < 18)
            {
                Console.Write("Eres un adolecente");
            }else if (edad <= 65)
            {
                Console.Write("Bienvenido al mundo de las responsabilidades");
            }
            else if(edad <= 80)
            {
                Console.WriteLine("Eres un adulto mayor");
            }
            else
            {
                Console.WriteLine("Larga vida");
            }



            Console.ReadLine();
        }
    }
}
