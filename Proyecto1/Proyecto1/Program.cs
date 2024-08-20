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
            //ejercicio encontrar la media aritmetica en la desviacion tipica de una serie de numeros mas la media armonica


            Console.Write("Ingrese la serie de numeros separados por comas: ");
            String serie = Console.ReadLine();
            String[] numeros = serie.Split(',');

            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1} ademas la media armonica es: {2} ", media(numeros), tipica(numeros),media_A(numeros));
            Console.Read();
        }

        static double media(string[] serie)
        {
            double media = 0;
            foreach (string num in serie)
            {
                media += int.Parse(num);

            }

            return media / serie.Length;

        }
        static double tipica(string[] serie)
        {
            double tipica = 0,
                   m = media(serie);
            foreach (string num in serie)
            {
                tipica += Math.Pow(int.Parse(num) - m, 2);
            }
            tipica = Math.Sqrt(tipica / serie.Length);

            return Math.Round(tipica, 2);

        }
        static double media_A(string[] serie)
        {
            int n = serie.Length;
            double armonica = 0;
           
            foreach(string num in serie)
            {
                armonica += 1 / int.Parse(num);
            }

            armonica = n / armonica;
            return armonica;
        }
    }
}
