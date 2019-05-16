using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] polynomial1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] polynomial2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                Console.Write((polynomial1[i]+polynomial2[i])+" ");
            }
            Console.WriteLine();
        }
    }
}
