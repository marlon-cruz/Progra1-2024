using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
   internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de funciones

            Console.WriteLine("El resultado de la suma es: {0}", sumar());

            Console.Write("Num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, sumar(num1, num2));

            Console.Read();
        }
       static int sumar()
        {
            int respuesta = 10 + 5;
            return respuesta;
        }
        static int sumar(int a, int b)
        {
            int respuesta = a +b;
            return respuesta;
        }

    }
}
