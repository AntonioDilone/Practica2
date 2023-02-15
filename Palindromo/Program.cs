using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que analiza un string y determina si es un palindromo");
            Console.WriteLine("Ingresar una palabra");
            string palabra = Console.ReadLine();
            string reverso = "";

            for (int i = palabra.Length - 1; i >=0 ; i--)
            {
                reverso += palabra[i];
            }

            if (palabra == reverso)
            {
                Console.WriteLine("La palabra es un palindromo");
            }
            else
            {
                Console.WriteLine("La palabra no es un palindromo");
            }
            Console.ReadLine();
        }
    }
}
