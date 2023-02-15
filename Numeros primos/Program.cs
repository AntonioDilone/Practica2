using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula una lista de numeros primos");
            bool Prime = true;

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    if (a != b && a % b == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                {
                    Console.Write("\t" + a);
                }
                Prime = true;
            }
            Console.ReadKey();
        }
    }
}

