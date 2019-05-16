using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            for (BigInteger i = n+1; i <= n+10; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
