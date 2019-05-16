using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    class Program
    {
        static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger result = input[0] - input[1];

            Console.WriteLine(result);
        }
    }
}
