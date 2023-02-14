using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_y_MCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el MCD y el MCM de dos numeros");

            Console.WriteLine("1- MCD 2- MCM");
            int opcion= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;
            int nume1= num1;
            int nume2= num2;

            switch (opcion)
            {
                case 1:
                    while (num2 != 0) {
                        result = num2;
                        num2 = num1 % num2;
                        num1 = result;
                    }
                    Console.WriteLine("El MCD entre estos numeros es " +result);
                    break;
                case 2:
                    while (num2 != 0) {
                        result = num2;
                        num2 = num1 % num2;
                        num1 = result;
                    }
                    result = (nume1/result) * nume2;
                    Console.WriteLine("El MCM entre estos numeros es " +result);
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
