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
            menus();
            Console.Read();
        }
        static void menus()
        {
            Console.WriteLine("######### 1 moneda #############");
            Console.WriteLine("######### 2 masa ###############");
            Console.WriteLine("######### 3 volumen ############");
            Console.WriteLine("######### 4 longitud ###########");
            Console.WriteLine("######### 5 almacenamiento #####");
            Console.WriteLine("######### 6 tiempo #############");
            Console.WriteLine("######### 0 salir ##############");



            try
            {
                Console.Write("Ingrea una opcion: ");
                int opcion_P = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion_P)
                {
                    case 0:
                        Console.Write("Saliste del programa");

                        break;
                    case 1:

                        break;
                    case 2:
                        Console.WriteLine("######### 1 Libras ##########");
                        Console.WriteLine("######### 2 Kilogramos ######");
                        Console.WriteLine("######### 3 Gramo ###########");
                        Console.WriteLine("######### 4 Onza ############");
                        Console.WriteLine("######### 5 Hectogramo ######");
                        Console.WriteLine("######### 6 Miligramo #######");
                        Console.WriteLine("######### 7 Tonelada ########");
                        Console.WriteLine("######### 8 Quintal #########");
                        Console.WriteLine("######### 9 Quilate #########");
                        Console.WriteLine("######### 10 Centigramo #####");
                        Console.WriteLine("######### 0 salir ###########");
                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("######### 1 metro  #############");
                        Console.WriteLine("######### 2 kilómetro  #########");
                        Console.WriteLine("######### 3 decámetro  #########");
                        Console.WriteLine("######### 4 centímetro  ########");
                        Console.WriteLine("######### 5 yarda  #############");
                        Console.WriteLine("######### 6 hectómetro  ########");
                        Console.WriteLine("######### 7 pulgada  ###########");
                        Console.WriteLine("######### 8 pie ################");
                        Console.WriteLine("######### 9 League  ############");
                        Console.WriteLine("######### 10 Milla náutica #####");
                        // Console.WriteLine("######### 0 salir ###########");
                        break;
                    case 5:

                        break;
                    case 6:
                        Console.WriteLine("######### 1 Segundo  ########");
                        Console.WriteLine("######### 2 Minuto  #########");
                        Console.WriteLine("######### 3 Hora  ###########");
                        Console.WriteLine("######### 4 Día  ############");
                        Console.WriteLine("######### 5 Semana  #########");
                        Console.WriteLine("######### 6 Año  ############");
                        Console.WriteLine("######### 7 Siglo  ##########");
                        Console.WriteLine("######### 8 Década  #########");
                        Console.WriteLine("######### 9 Lustro  #########");
                        Console.WriteLine("######### 10 Trienio ########");
                        Console.WriteLine("######### 0 salir ###########");
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Ingresa una opcion disponible\n");
                        menus();
                        break;

                }
                if (opcion_P != 0)
                {
                    Console.Write("Ingresa una opcion: ");
                    int opc = int.Parse(Console.ReadLine());
                    if (opc == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Regreso al menu principal");
                        menus();
                    }
                    else
                    {
                        Console.Write("Ingresa una opcion para la conversion: ");

                        int opc2 = int.Parse(Console.ReadLine());

                        Console.Write("Ingresa la cantidad a combertir: ");

                        double cantidad = double.Parse(Console.ReadLine());

                        conversion(opc, opc2, cantidad, opcion_P);
                    }

                }

            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Ingresa una opcion disponible\n");
                menus();
            }

        }
        static void conversion(int opcion1, int opcion2, double cant, int opcion_1p)
        {
            string[] text_masa = new string[] { "libras", "kilogramos", "gramos", "onzas", "hectogramos", "miligramos", "toneladas", "quintales", "quilates", "centigramo" };

            double[,] masa = new double[,]
             {
                 //libra | kilogramo | gramos |Onzas|hectogramo |miligramo| tonelada   |quintal   |quilate|centigramo
                {1           ,0.453592  ,453.592      ,16         ,4.53592   ,453592     ,0.000453592 ,0.00453592  ,2267.96  ,45359.2 }, //lb
                {2.20462     ,1         ,1000         ,35.274     ,10        ,1000000    ,0.001       ,0.01        ,5000     ,100000}, //kg
                {0.00220462  ,0.001     ,1            ,35.274     ,0.01      ,1000       ,0.000001    ,0.00001     ,5        ,100}, //g
                {0.0625      ,0.0283495 ,28.3495      ,1          ,0.283495  ,28349.5    ,0.00002835  ,0.000283495 ,141.748  ,29.5735}, //oz
                {0.2205      ,0.1       ,100          ,3.5274     ,1         ,100000     ,0.0001      ,0.002       ,500      ,10000}, //hg
                {0.000002205 ,0.000001  ,0.001        ,0.00003527 ,0.00001   ,1          ,0.000000001 ,0.00000002  ,0.005    ,0.1}, //ml
                {2204.62     ,1000      ,1000000      ,35273.96   ,10000     ,1000000000 ,1           ,10          ,5000000  ,100000000}, //t
                {220.462     ,100       ,100000       ,3527.396   ,1000      ,100000000  ,0.1         ,1           ,500000   ,10000000}, //quilates
                {0.0004409   ,0.0002    ,0.2          ,0.0070548  ,0.002     ,200        ,0.0000002   ,0.00002     ,1        ,20 }, //ct
                {0.00002205  ,0.00001   ,0.01         ,0.0003527  ,0.0001    ,10         ,0.0000001   ,0.000001    ,0.05     ,1}, //cg

             };
            string[] text_tiempo = new string[] { "segundo", "minutos", "horas", "dias", "semanas", "años", "siglos", "decadas", "lustro", "trienio" };

            double[,] tiempo = new double[,]
            {
                //segundo     | minuto   | hora   | dia       | semana    | año         | siglo         | decada       | lustro       | trienio |
                {1           ,0.0167     ,0.000278 ,0.0000116 ,0.00000165 ,0.0000000317 ,0.000000000317 ,0.00000000317 ,0.00000000634 ,0.0000000106},//segundo
                { 60         ,1          ,0.0167   ,0.000694  ,0.0000992  ,0.0000019    ,0.000000019    ,0.00000019    ,0.00000038    ,0.00000057  },//min
                { 3600       ,60         ,1        ,0.0417    ,0.00595    ,0.000114     ,0.00000114     ,0.0000114     ,0.0000228     ,0.0000342   },//hora
                { 86400      ,1440       ,24       ,1         ,0.142857   ,0.00274      ,0.0000274      ,0.000274      ,0.000548      ,0.000822  },//dia
                { 604800     ,10080      ,168      ,7         ,1          ,0.0192       ,0.000192       ,0.00192       ,0.00384       ,0.00641 },//semana
                { 31536000   ,525600     ,8760     ,365       ,52.14      ,1            ,0.01           ,0.1           ,0.2           ,0.333  },//año
                { 3153600000 ,52560000   ,876000   ,36500     ,5214       ,100          ,1              ,10            ,20            ,33.33 },//siglo
                { 315360000  ,5256000    ,87600    ,3650      ,521.4      ,10           ,0.1            ,1             ,2             ,3.33 },//decada
                { 157680000  ,2628000    ,43800    ,1825      ,260.7      ,5            ,0.05           ,0.5           ,1             ,1.67},//listro
                { 94608000   ,1576800    ,26280    ,1095      ,156.43     ,3            ,0.03           ,0.33          ,0.6           ,1 },//trienio
            };

            string[] text_longitud = new string[] { "metros", "kilometros", "decametros", "yarda", "hectometro", "pulgadas", "pies", "league", "millas nauticas" };
            double[,] longitud = new double[,]
            {
                //metro |kilómetro |decámetro|centímetro|yarda |hectómetro |pulgada |pie        |League         | Milla náutica
                {1      ,0.001      ,0.1     ,100      ,1.09361   ,0.01     ,39.3701  ,3.28084   ,0.000207124    ,0.000539957},//metro
                {1000   ,1          ,100     ,100000   ,1093.61   ,10       ,39370.1  ,3280.84   ,0.207124       ,0.539957},//kilometro
                {10     ,0.01       ,1       ,1000     ,10.9361   ,0.1      ,393.701  ,32.8084   ,0.00207124     ,0.00539957},//decametro
                {0.01   ,0.00001    ,0.001   ,1        ,0.0109361 ,0.0001   ,0.393701 ,0.0328084 ,0.00000207124  ,0.00000539957},//centimetro
                {0.9144 ,0.0009144  ,0.09144 ,91.44    ,1         ,0.009144 ,36       ,3         ,0.000189394    ,0.000493737},//yarda
                {100    ,0.1        ,10      ,10000    ,109.361   ,1        ,3937.01  ,328.084   ,0.0207124      ,0.0539957},//hectometro
                {0.0254 ,0.0000254  ,0.00254 ,2.54     ,0.0277778 ,0.000254 ,1        ,0.0833333 ,0.0000137149   ,0.0000137149},//pulgada
                {0.3048 ,0.0003048  ,0.03048 ,30.48    ,0.333333  ,0.003048 ,12       ,1         ,0.000063131    ,0.00016131},//pie
                {4828   ,4.828      ,482.8   ,482800   ,5280      ,48.28    ,190080   ,15840     ,1              ,2.607},//legua
                {1852   ,1.852      ,185.2   ,185200   ,2025.37   ,18.52    ,72913.4  ,607612    ,0.542          ,1},//milla nautica
            };





            switch (opcion_1p)
            {
                case 1:

                    break;
                case 2:
                    double conversion_2 = masa[opcion1 - 1, opcion2 - 1];
                    Console.WriteLine("El resultado de la conversion es: {0} en {1}", cant * conversion_2, text_masa[opcion2 - 1]);
                    break;
                case 3:
                    break;
                case 4:
                    double conversion_4 = longitud[opcion1 - 1, opcion2 - 1];
                    Console.WriteLine("El resultado de la conversion es: {0} en {1}", cant * conversion_4, text_tiempo[opcion2 - 1]);
                    break;
                case 5:
                    break;
                case 6:
                    double conversion_6 = tiempo[opcion1 - 1, opcion2 - 1];
                    Console.WriteLine("El resultado de la conversion es: {0} en {1}", cant * conversion_6, text_longitud[opcion2 - 1]);
                    break;

            }


        }
    }
}
