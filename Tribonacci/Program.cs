using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            long third = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger[] tribonacci = new BigInteger[n];
            tribonacci[0] = first;
            tribonacci[1] = second;
            tribonacci[2] = third;

            for (int i = 3; i < n; i++)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];

            }

            Console.WriteLine(tribonacci[n-1]);

        }
    }
}
