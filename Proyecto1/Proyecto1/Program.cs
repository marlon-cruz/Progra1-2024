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
            opciones();
            Console.Read();

        }
        static void opciones()
        {

            Console.WriteLine("##############################################");
            Console.WriteLine("######### Elija una opcion a utilizar ########");
            Console.WriteLine("######### 1. Caculo de actividad econimica ###");
            Console.WriteLine("######### 2. Comberciones de medidas de area #");
            Console.WriteLine("######### 0. salir ###########################");
            Console.WriteLine("############################################\n");

            try
            {
                Console.Write("Ingresa una opcion: ");
                int opc_p = int.Parse(Console.ReadLine());

                switch (opc_p)
                {
                    case 0:
                        Console.WriteLine("Has salido del programa");
                        break;

                     case 1:
                        a_economica();
                        break;
                    case 2:
                        Combercion_area();
                        break;
                    default:
                        Console.WriteLine("Ingresa una opcion disponible");
                        opciones();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo ha salido mal\nIntentelo nuevamente");
                Console.Clear();
                opciones();

            }


        }

        static void a_economica()
        {
            // MPUESTO A LAS ACTIVIDADES ECONOMICAS

            double[,] actividad_eco = new double[,] {
            //DESDE     HASTA   PRECIO   ADICIONAL
            {0.01,       500,     1.5,     0},
            {500.01,     1000,    1.5,     3},
            {1000.01,    2000,     3,      3},
            {2000.01,    3000,     6,      3},
            {3000.01,    6000,     9,      2},
            {8000.01,    18000,    15,     2},
 
            {18000.01,   30000,    39,     2},
            
            {30000.01,   60000,    63,     1},
            {60000.01,   100000,   93,   0.8},
            {100000.01,  200000,   125,  0.7},
            {200000.01,  300000,   195, 0.6 },
            {300000.01,  400000,   255, 0.45},
            {400000.01,  500000,   300,  0.4},
            {500000.01,  1000000,  340, 0.30},
            {1000000.01, 99999999, 490, 0.18},
            };
            try
            {
                Console.Write("Ingrese su monto de su actividad economica: ");
                double monto = double.Parse(Console.ReadLine());
                double actividad = 0;
                for (int i = 0; i < 15; i++)
                {

                    if (monto >= actividad_eco[i, 0])
                    {
                        if (monto <= actividad_eco[i, 1])
                        {
                            actividad = monto - actividad_eco[i, 0];
                            actividad = actividad / 1000 * actividad_eco[i, 3] + actividad_eco[i,2];

                        }
                    }
                    
                }
                Console.WriteLine("Los impuestos por la actividad economica son: {0}", actividad);
                
            }
            catch (Exception)
            {

                Console.WriteLine("Algo ha salido mal\nIntentelo nuevamente");
                a_economica();
            }
        }
    static void Combercion_area()
        {
            Console.WriteLine("######################################");
            Console.WriteLine("######## 1. pie cuadrado #############");
            Console.WriteLine("######## 2.vara cuadrada #############");
            Console.WriteLine("######## 3.yarda cuadrada ############");
            Console.WriteLine("######## 4.metro cuadrado ############");
            Console.WriteLine("######## 5.tareas #####################");
            Console.WriteLine("######## 6. manzanas ##################");
            Console.WriteLine("######## 7. Hectaria ##################");

            double[,] area = new double[,] {
            //Pie Cuadrado     Vara Cuadrada   Yarda Cuadrada   Metro Cuadrado        Tareas               Manzana        Hectárea
            {1                 ,0.1111          ,0.111111          ,0.092903    ,0.000147746563489,    0.000013188969818, 0.0000092937},//pie cuadrado,////Pie Cuadrado 
            {9,                      1,            0.8357,          0.698896,     0.0011173378658,         0.0001,          0.0000698},//Vara Cuadrada 
            {9,                  1.185,                 1,          0.836127,      0.001329719084,         0.0001199,       0.000083612},//Yarda Cuadrada
            {10.7639,            1.431,           1.19599,           1,               0.0015903307888,     0.0001434,        0.0001},//Metro Cuadrado
            {6768.34687,        894.98443633736,  752.03854111,     628.8,              1,               0.08926746167,      0.06288},//Tareas
            {75820.984975,      10000 ,           8424.553886,      7044,            11.202290076,       1,         0.698896},//Manzana
            { 107639           ,14312             ,11959.9        ,10000              ,15.9,                 1.4184,                 1},//hectaria
            };

            try
            {
                Console.Write("Ingresa la opcion 1: ");
                int opc1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la opcion 2: ");
                int opc2 = int.Parse(Console.ReadLine());

                Console.Write("ingresa la cantidad: ");
                int cant = int.Parse(Console.ReadLine());


                switch (opc1)
                {
                    case 1:
                        double conversion_1 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_1);
                        break;
                    case 2:
                        double conversion_2 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_2);
                        break;
                    case 3:
                        double conversion_3 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_3);
                        break;
                    case 4:
                        double conversion_4 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_4);
                        break;
                    case 5:
                        double conversion_5 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_5);
                        break;
                    case 6:
                        double conversion_6 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_6);
                        break;
                    case 7:
                        double conversion_7 = area[opc1 - 1, opc2 - 1];
                        Console.WriteLine("El resultado de la conversion es: {0}", cant * conversion_7);
                        break;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}