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
                Console.Write("Ingresa una opcion: ");
                int opcion_P = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion_P)
                {
                    case 0:
                        Console.Write("Saliste del programa");

                        break;
                    case 1:
                        Console.WriteLine("######### Opciones de monedas #########");
                        Console.WriteLine("######### 1 Dólar estadounidense ######");
                        Console.WriteLine("######### 2 Euro ######################");
                        Console.WriteLine("######### 3 Quetzal ###################");
                        Console.WriteLine("######### 4 Peso Mexicano #############");
                        Console.WriteLine("######### 5 Peso cubano ###############");
                        Console.WriteLine("######### 6 Peso argentino ############");
                        Console.WriteLine("######### 7 Real brasileño ############");
                        Console.WriteLine("######### 8 Sol peruano ###############");
                        Console.WriteLine("######### 9 Colón costarricense #######");
                        Console.WriteLine("######### 10 Lempira hondureña ########");
                        Console.WriteLine("######### 0 Menu principal ############");
                        break;
                    case 2:
                        Console.WriteLine("######### Opciones de masa ##");
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
                        Console.WriteLine("######### 0 Menu principal ##");
                        break;
                    case 3:
                        Console.WriteLine("######### Opciones de volumen #####");
                        Console.WriteLine("######### 1 Galones (EE. UU) ######");
                        Console.WriteLine("######### 2 Galones UK ############");
                        Console.WriteLine("######### 3 Litro #################");
                        Console.WriteLine("######### 4 Mililitro #############");
                        Console.WriteLine("######### 5 Centilitro ############");
                        Console.WriteLine("######### 6 Metro Cúbico ##########");
                        Console.WriteLine("######### 7 Taza imperial #########");
                        Console.WriteLine("######### 8 Onza imperial #########");
                        Console.WriteLine("######### 9 Pie cúbico ############");
                        Console.WriteLine("######### 10 Pulgada cúbica #######");
                        Console.WriteLine("######### 0 Menu principal ########");
                        break;
                    case 4:
                        Console.WriteLine("######### Opciones de longitud #");
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
                        Console.WriteLine("######### 0 Menu principal #####");
                        break;
                    case 5:
                        Console.WriteLine("######### Opciones de almacenamiento #");
                        Console.WriteLine("######### 1 Bits #####################");
                        Console.WriteLine("######### 2 Bytes ####################");
                        Console.WriteLine("######### 3 Kilobytes ################");
                        Console.WriteLine("######### 4 Kilobibytes ##############");
                        Console.WriteLine("######### 5 Megabytes ################");
                        Console.WriteLine("######### 6 Megabibytes ##############");
                        Console.WriteLine("######### 7 Gigabytes ################");
                        Console.WriteLine("######### 8 Terabytes ################");
                        Console.WriteLine("######### 9 Petabytes ################");
                        Console.WriteLine("######### 10 Exabytes ################");
                        Console.WriteLine("######### 0 Menu principal ###########");
                        break;
                    case 6:
                        Console.WriteLine("######### Opciones de tiempo ##");
                        Console.WriteLine("######### 1 Segundo  ##########");
                        Console.WriteLine("######### 2 Minuto  ###########");
                        Console.WriteLine("######### 3 Hora  #############");
                        Console.WriteLine("######### 4 Día  ##############");
                        Console.WriteLine("######### 5 Semana  ###########");
                        Console.WriteLine("######### 6 Año  ##############");
                        Console.WriteLine("######### 7 Siglo  ############");
                        Console.WriteLine("######### 8 Década  ###########");
                        Console.WriteLine("######### 9 Lustro  ###########");
                        Console.WriteLine("######### 10 Trienio ##########");
                        Console.WriteLine("######### 0 Menu principal ####");
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
                    if (opc == 0 || opc > 10 || opc < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Regreso al menu principal");
                        menus();
                    }
                    else
                    {
                        Console.Write("Ingresa una opcion para la conversion: ");

                        int opc2 = int.Parse(Console.ReadLine());
                        if (opc2 == 0 || opc2 > 10 || opc2 < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Regreso al menu principal");
                            menus();
                        }
                        else
                        {
                            Console.Write("Ingresa la cantidad a combertir: ");

                            double cantidad = double.Parse(Console.ReadLine());

                            conversion(opc, opc2, cantidad, opcion_P);
                        }

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
            String[] text_monedas = new string[] { "dolares", "euros", "quetzales", "pesos Mexicanos", "pesos Cubanos", "pesos Argentinos", "Real Brasileño", "sol Peruano ", "colon costarricense", "lempira Hondureña" };
            Double[,] monedas = new double[,] {
                //Dolar | Euro | Quetzal |Peso MX | Peso CB | Peso AR | Real BRA | Sol PE | Colon CR | Lempira H |
                { 1,     0.91,    7.75,     18.69,    24,      941.26,    5.48,      3.74,    526.09,     24.78},//Dolar
                {1.10,    1,      8.52,     20.53,    26.38,   1034.51,   6.02,      4.11,    578.24,     27.24},//Euro
                {0.13,   0.12,     1,       2.41,     3.1,     121.58,    0.71,      0.48,    67.95,       3.20},//Qutzal
                {0.054,  0.049,   0.42,       1,      1.29,    50.47,     0.29,      0.20,    28.2,        1.33},//Peso MX
                {0.042,  0.038,   0.32,     0.78,      1,      39.21,     0.23,      0.16,    21.92,       1.03},//Peso Cubano
                {0.0011, 0.00097, 0.0082,   0.020,    0.026,     1,       0.0058,    0.0040,  0.56,        0.026},//Peso AR
                {0.18,   0.17,    1.41,     3.40,     4.38,    171.88,      1,       1.46,    96.08,        4.53},//Real BRA
                {0.27,   0.24,    2.07,     4.98,     6.41,    251.51,    1.46,       1,      140.60,       6.63},//Sol PE
                {0.0019, 0.0017,  0.015,    0.035,    0.046,   1.79,      0.010,     0.0071,    1,         0.047},//Colon CR
                {0.04,   0.37,    0.31,     0.75,     0.97,    37.93,     0.22,      0.15,    21.2,            1},//Lempira
                };
            //VALORES DE MONDEDAS ACTUALIZA HASTA EL 17 DE AGOSTO DEL 2024

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
            string[] text_volumen = new string[] { "Galones (EE. UU.)", "Galones UK", "Litro", "Mililitro", "Centilitro", "Metro Cúbico", "Taza imperial", "Onza imperial", " Pie cúbico", "Pulgada cúbica" };
            Double[,] volumen = new double[,] {
//Galones (EE. UU.) |  Galones UK  |    Litro    |    Mililitro   |  Centilitro  |  Metro Cúbico  |  Taza imperial  |  Onza imperial |  Pie cúbico   |  Pulgada cúbica   |
{0.832674,             1,              3.78541,     3785.41,        378.541,       0.00378541,        15.7725,         133.227,           0.133681,            231},//Galones (EE. UU.)
{1,                   1.20095,         4.54609,     4546.09,        454.609,       0.00454609,        18.18436,          160,             0.160544,        277.419},//Galones UK
{0.219969,            0.264172,          1,         1000,           100,           0.001,             3.51951,         35.1951,           0.035315,        61.0237},//Litro
{0.000219969,         0.000264172,     0.001,         1,            0.1,           0.000001,          0.00351951,      0.0351951,         0.000035315,   0.0610237},//Mililitro
{0.00219969,          0.00264172,      0.01,          10,            1,            0.00001,           0.0351951,       0.351951,          0.00035315,     0.610237},//Centilitro
{219.969,             264.172,         1000,        1000000,        100000,           1,              3519.51,         35195.1,           35.315,          61023.7},//Metro Cúbico
{0.0625,              0.075,           0.284131,    284.131,        28.4131,       0.000284131,         1,               10,              0.0100224,       17.3387},//Taza imperial
{0.00625,             0.00750594,      0.0284131,   28.4131,        2.84131,       0.0000284131,       0.1,              1,               0.00100224,      1.73387},//Onza imperial 
{6.22884,             7.48052,         28.3168,     28316.8,        2831.68,       0.0283168,         99.6614,         996.614,              1,               1728},//Pie cúbico
{0.00360465,          0.004329,        0.0163871,   16.3871,        1.63871,       0.0000163871,      0.0666667,       0.576744,          0.000578704,           1},//Pulgada cúbica
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

            String[] text_almacenamiento = new string[] { "bits", "bytes", "kilobytes", "kilobibytes", "megabytes", "megabibytes", "gigabytes", "terabytes", "petabytes", "exabytes" };
            Double[,] Almacenamiento = new double[,] {
//Bits              |     Bytes          |    Kilobytes    |    Kilobibytes     |    Megabytes  |        Megabibytes        |  Gigabytes     |   Terabytes       |       Petabytes       |       Exabytes         |
{1,                   0.125,                0.000125,         0.0001220703125,    0.000000125,    0.00000011920928955078125,  0.000000000125, 0.000000000000125,   0.000000000000000125,  0.000000000000000000125},//Bit
{8,                     1,                  0.001,            0.0009765625,       0.000001,       0.00000095367431640625,     0.000000001,    0.000000000001,      0.000000000000001,        0.000000000000000001},//Bytes
{8000,                1000,                   1,              0.9765625,          0.001,          0.00095367431640625,        0.000001,       0.000000001,         0.000000000001,              0.000000000000001},//Kilobytes
{8192,                1024,                 1.024,               1,               0.001024,       0.0009765625,               0.000001024,    0.000000001024,      0.000000000001024,        0.000000000000001024},//Kilobibytes
{8000000,             1000000,              1000,             976.5625,              1,           0.95367431640625,           0.001,          0.000001,            0.000000001,                    0.000000000001},//Megabytes
{8388608,             1048576,              1048.576,         1024,               1.048576,            1,                     0.001048576,    0.000001048576,      0.000000001048576,        0.000000000001048576},//Megabibytes
{8000000000,          1000000000,           1000000,          976562.5,           1000,           953.67431640625,               1,           0.001,               0.000001,                          0.000000001},//Gigabytes
{8000000000000,       1000000000000,        1000000000000,    976562500,          1000000,        953674.31640625,            1000,            1,                  0.001,                                0.000001},//Terabytes 
{8000000000000000,    1000000000000000,     1000000000000,    976562500000,       1000000000,     95367431640625,             1000000,        1000,                  1,                                     0.001},//Petabytes
{8000000000000000000, 1000000000000000000,  1000000000000000, 976562500000000,    1000000000000,  953674316406.25,            1000000000,     1000000,             1000,                                        1},//Exabytes
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



            switch (opcion_1p)
            {
                case 1:
                    double conversion_1 = monedas[(int)opcion1 - 1, (int)opcion2 - 1];
                    Console.WriteLine("El resultado de la conversión es: {0} en {1}", Math.Round(cant * conversion_1, 2), text_monedas[(int)opcion2 - 1]);
                    break;
                case 2:
                    double conversion_2 = masa[opcion1 - 1, opcion2 - 1];
                    Console.WriteLine("El resultado de la conversion es: {0} en {1}", cant * conversion_2, text_masa[opcion2 - 1]);
                    break;
                case 3:
                    double conversion_3 = volumen[(int)opcion1 - 1, (int)opcion2 - 1];
                    Console.WriteLine("El resultado de la conversión es: {0} en {1}", cant * conversion_3, text_volumen[(int)opcion2 - 1]);
                    break;
                case 4:
                    double conversion_4 = longitud[opcion1 - 1, opcion2 - 1];
                    Console.WriteLine("El resultado de la conversion es: {0} en {1}", cant * conversion_4, text_tiempo[opcion2 - 1]);
                    break;
                case 5:
                    double conversion_5 = Almacenamiento[(int)opcion1 - 1, (int)opcion2 - 1];
                    Console.WriteLine("El resultado de la conversión es: {0} en {1}", cant * conversion_5, text_almacenamiento[(int)opcion2 - 1]);
                    break;
                case 6:
                    double conversion_6 = tiempo[opcion1 - 1, opcion2 - 1];
                    Console.WriteLine("El resultado de la conversion es: {0} en {1}", cant * conversion_6, text_longitud[opcion2 - 1]);
                    break;

            }

            Console.WriteLine("Presione enter para continuar: ");

            string continuar = Console.ReadLine();
            if (continuar == "")
            {
                Console.Clear();
                menus();
            }

        }
    }
}