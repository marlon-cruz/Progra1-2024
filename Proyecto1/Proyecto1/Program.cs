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
            //Uso de matrices.
            //Uso de matrices.
            int[] numeros = new int[] { 2, 8, 9, 10, 1, 3 };
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Indice: {0}={1}", i, numeros[i]);
                int[,] matriz = new int[,] {
                {5,4,5,2,1},
                {1,2,8,9,3}
            };
                for (int n = 0; n < 2; n++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("{0} ", matriz[n, j]);
                    }
                    Console.WriteLine("\n");
                }
                //Pausa
                Console.ReadKey();
            }
        }

    }
}
