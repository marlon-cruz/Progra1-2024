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
            //Uso de matriz
            int[] numeros = new int[] { 2, 8, 9, 10,18, 1, 3 };
            //Mostrar contenido de una posicion en la patriz
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Indice: {0} = {1}", i, numeros[i]);
            }

            //Pausa
            Console.Read();
        }
    }

}
