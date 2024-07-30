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

            if(edad >= 18)
            {
                Console.WriteLine("Bienvenido al mundo de las responsabilidades");
            }
            else
            {
                Console.WriteLine("Eres un adolecente disfruta de la vida");
            }



            Console.ReadLine();
        }
    }
}
