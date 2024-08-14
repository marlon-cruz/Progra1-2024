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

            int[] serie = new int[] { 5, 9, 4, 6, 3, 2 };
            foreach (int num in serie)
            {
                Console.WriteLine("El num {0} es {1}", num, num % 2 == 0 ? "par" : "Impar");
            }




            Console.Read();
   
        
        
        }

    }
}
