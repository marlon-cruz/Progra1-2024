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
            //determinar si un numero es primo

            int[] serie = new int[] { 5, 9, 4, 6, 3, 2,7,11,15,17,21 };
            foreach (int num in serie)
            {
                int i = 1;
                int n = 0;
                while(i <= num && n <= 2)
                {
                    if (num % i == 0)
                    {
                        n++;
                       
                    }
                    i++;
                }
                Console.WriteLine("El numero {0} es {1}", num, n <= 2 ? "Es primo" : "No es primo");
            }

            Console.Read();

           }

    }
}
