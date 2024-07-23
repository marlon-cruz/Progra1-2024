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
            Console.Write("lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("parcial1: ");
            double pacial_1 = double.Parse(Console.ReadLine());

            double c1 = lab1 * 30 / 100 + lab2 * 20 / 100 + pacial_1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            if (c1 < 6)
            {
                Console.WriteLine("No has aprobado hay que mejorar");
            }
            else
            {
                Console.WriteLine("Has aprobado sigue asi");
            };
            Console.WriteLine("Inicia el computo 2");

            Console.Write("Lab1 de c2: ");
            double lab1_c2 = double.Parse(Console.ReadLine());

            Console.Write("Lab2 de c2: ");
            double lab2_c2 = double.Parse(Console.ReadLine());

            Console.Write("parcial de c2: ");
            double parcial_2 = double.Parse(Console.ReadLine());
            double c2 = lab1_c2 * 30 / 100 + lab2_c2 * 30 / 100 + parcial_2 * 40 / 100;

            Console.WriteLine("La calificación de c2 es: {0}", c2);

            if (c2 < 6)
            {
                Console.WriteLine("No has aprobado hay que mejorar");
            }
            else
            {
                Console.WriteLine("Has aprobado sigue asi");
            };
            Console.WriteLine("Inicia el computo 3: ");

            Console.Write("Lab1 de c3: ");
            double lab1_c3 = double.Parse(Console.ReadLine());

            Console.Write("Lab2 de c3: ");
            double lab2_c3 = double.Parse(Console.ReadLine());

            Console.Write("parcial de c3: ");
            double parcial_3 = double.Parse(Console.ReadLine());
            double c3 = lab1_c3 * 30 / 100 + lab2_c3 * 30 / 100 + parcial_3 * 40 / 100;

            Console.WriteLine("La calificación de c2 es: {0}", c3);

            if (c3 < 6)
            {
                Console.WriteLine("No has aprobado los demas computos ayudaran");
            }
            else
            {
                Console.WriteLine("Has aprobado sigue asi");
            };

            double nota_final = (c1 + c2 + c3) / 3;
            Console.WriteLine("Conoscamos tu calificacion final");

            Console.WriteLine("Tu calificacion final es: {0}", nota_final);
            if (nota_final < 6)
            {
                Console.WriteLine("Has reprobado la materia");
            }
            else
            {
                Console.WriteLine("Has aprobado la materia, --Felicidades--");
                Console.ReadLine();
            }
            Console.ReadLine();
        

        }
    }
}
