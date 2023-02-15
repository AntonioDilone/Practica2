using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loteria nacional");
            Console.WriteLine("Cantidad de numeros de la tombola");
            int cant = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i <= cant; i++)
            {
                int a = rnd.Next(1,99);
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
