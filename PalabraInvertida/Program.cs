using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que inverte las palabras");
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            string reverso = "";
            for (int i = palabra.Length - 1; i >= 0 ; i--)
            {
                reverso+= palabra[i];
            }
            Console.WriteLine(reverso);
            Console.ReadLine();

        }
    }
}
