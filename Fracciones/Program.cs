using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que convierte fracciones mixtas en fracciones comunes");
            Console.WriteLine("Ingrese el numero entero");
            int ent = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numerador de la fraccion");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el denominador de la fraccion");
            int den = int.Parse(Console.ReadLine());

            int num2 = (ent * den) + num;
            

            Console.WriteLine("Su nueva fraccion es " + num2 + "/" + den);
            Console.ReadLine();
        }
    }
}
