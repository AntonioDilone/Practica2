using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular cantidad de semanas entre dos fechas");
            Console.WriteLine("Ingrese la fecha incial (Formato: 8/24/2017)");
            string fech1 = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha final");
            string fech2 = Console.ReadLine();
            var fecha1 = DateTime.Parse(fech1.ToString());
            var fecha2 = DateTime.Parse(fech2.ToString());
            double weeks = (fecha1 - fecha2).TotalDays / 7;
            Console.WriteLine("Cantidad de semanas " + weeks);
            Console.ReadLine();
        }
    }
}
