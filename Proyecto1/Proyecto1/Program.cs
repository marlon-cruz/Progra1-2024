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
            int suma = 0; //prioridad de operadores aritmeticos
            //ejercicion promedio de una serie de numeros

            int[] serie = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5 };//matriz unidireccional

            foreach (int num in serie)
            {
                suma += num;

            }
            float promedio = serie.Length;

            Console.WriteLine("La suma es: {0}, el promedio es: {1}", suma, suma / promedio);

            //pausa para ver que hay en el programa
            Console.ReadLine();
        

        }
    }
}
