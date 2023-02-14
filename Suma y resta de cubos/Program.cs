using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_y_resta_de_cubos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que suma y resta cubos");
            Console.WriteLine("1-Suma 2-Resta");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b");
            int b = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    double resulta = (int)Math.Ceiling((int)Math.Pow(a, 1/3));
                    double resulta2 = Math.Pow(resulta,2);
                    double resultb = Math.Ceiling(Math.Pow(a, 1 / 3));
                    double resultb2 = Math.Pow(resultb,2);

                    Console.WriteLine("El resultado es ("+ resulta +"+"+ resultb+")("+resulta2+"-"+resulta+resultb+"+"+resultb2+")");

                    break;
                case 2:
                    Console.WriteLine();
                    break;
            }

            Console.ReadLine();
        }
    }
}
