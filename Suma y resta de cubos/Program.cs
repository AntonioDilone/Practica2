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
            double c = 0.33;

            double resulta = Math.Round(Math.Pow(a, c));
            double resulta2 = Math.Round(Math.Pow(resulta, 2));
            double resultb = Math.Round(Math.Pow(b, c));
            double resultb2 = Math.Round(Math.Pow(resultb, 2));
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El resultado es ("+ resulta +"+"+ resultb+")("+resulta2+"-"+resulta*resultb+"+"+resultb2+")");
                    break;
                case 2:
                    Console.WriteLine("El resultado es (" + resulta + "-" + resultb + ")(" + resulta2 + "+" + resulta * resultb + "+" + resultb2 + ")");
                    break;
            }

            Console.ReadLine();
        }
    }
}
