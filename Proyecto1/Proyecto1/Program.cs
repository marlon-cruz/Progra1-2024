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

            Console.Read();
        }
       static int sumar()
        {
            int respuesta = 10 + 5;
            return respuesta;
        }

    }
}
