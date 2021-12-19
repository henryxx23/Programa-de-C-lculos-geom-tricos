using System;
using System.Linq;

namespace Programa_Clases_C_SHARP
{
    class Calculo_de_area
    {
        public static string opcion;
        public static double pi = 3.14;
        class bloque_calculo
        {
            public static int vrad;
            public static int vbase;
            public static int valt;
            public static double resultado;

            public void area_triangulo()
            {
                Console.WriteLine("Introduzca la base del triangulo:");
                vbase = Int32.Parse(Console.ReadLine());
                Double x = (Double)vbase;
                Console.WriteLine("Introduzca la altura del triangulo:");
                valt = Int32.Parse(Console.ReadLine());
                Double y = (Double)valt;
                resultado = (valt * vbase) / 2;
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void area_circulo()
            {
                Console.WriteLine("Introduzca el radio del circulo:");
                vrad = Int32.Parse(Console.ReadLine());
                Double x = (Double)vrad;
                resultado = pi * (x * x);
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void area_rectangulo()
            {
                Console.WriteLine("Introduzca la base del rectangulo:");
                vbase = Int32.Parse(Console.ReadLine());
                Double x = (Double)vbase; menu();
                Console.WriteLine("Introduzca la altura del rectangulo:");
                valt = Int32.Parse(Console.ReadLine());
                Double y = (Double)valt;
                resultado = vbase * valt;
                System.Console.WriteLine("El resultado es: " + resultado);
            }
            public void menu()
            {
                Console.WriteLine("Area a calcular \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");

            }

        }
        static void Main(string[] args)
        {
            bloque_de_calculo sub= new bloque_de_calculo();
            string marco = string.Concat(Enumerable.Repeat("*", 50));
            System.Console.WriteLine(marco + "\n\t Programa geometrico \n" + marco);
            Console.WriteLine("Area a calcular: \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n");
            while (opcion != "s")
            {
                System.Console.WriteLine("Ingrese su opcion: ");
                opcion = Console.ReadLine();
                System.Console.WriteLine();
                Console.Clear();
                if (opcion == "s")
                {
                    System.Console.WriteLine("\n\nGracias por utilizar el calculo geometrico\n\n");
                    break;
                }
                else if (opcion == "c")
                {
                    sub.area_circulo();
                    string marco2 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco2);
                    sub.menu();
                }
                else if (opcion == "r")
                {
                    sub.area_rectangulo();
                    string marco3 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco3);
                    sub.menu();
                }
                else if (opcion == "t")
                {
                    sub.area_triangulo();
                    string marco4 = string.Concat(Enumerable.Repeat("= ", 50));
                    System.Console.WriteLine(marco4);
                    sub.menu();
                }
                else
                {
                    System.Console.WriteLine("Error, Introduzca una tecla mostrada en el menu");
                    System.Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    sub.menu();
                }
            }
        }
    }
}