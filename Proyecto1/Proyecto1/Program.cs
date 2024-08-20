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
            //Uso de funcionesy matrices
            //ejercicio encontrar la media aritmetica en la desviacion tipica de una serie de numeros

            int[] serie = new int[] {1,2,3,4,5};


            Console.WriteLine("La media aritmetca es: {0} y la desviacion tipica es: {1}",media(serie),tipica(serie));
            Console.Read();
        }
      
        static double media(int[] serie)
        {
            double media = 0;
            foreach (int num in serie)
            {
                media += num;

            }

            return media / serie.Length;

        }
        static double tipica(int[] serie)
        {
            double tipica = 0;
            double m = media(serie);
            foreach(int num in serie)
            {
                tipica += Math.Pow(num - m, 2);
            }
            tipica = Math.Sqrt(tipica / serie.Length);
            return tipica;

        }
    }
}
