using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBiciesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que determina si un año es bisiesto o no");
            Console.WriteLine("Ingrese el año");
            int año = int.Parse(Console.ReadLine());
            if (año % 4 == 0 )
            {
                Console.WriteLine(año+" es bisiesto");
            } else Console.WriteLine("No es bisiesto");
            Console.ReadLine();
        }
    }
}
