using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTower
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int N = 3;

            // A, B and C are names of rods
            towerOfHanoi(N, 'A', 'C', 'B');
        }
        static void towerOfHanoi(int n, char from_rod,
                             char to_rod, char aux_rod)
        {
            if (n == 0)
            {
                return;
            }
            towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod "
                              + from_rod + " to rod " + to_rod);
            towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }
    }
}
