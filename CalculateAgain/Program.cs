using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactoriel = nFactoriel * i;
                if (i<=k)
                {
                    kFactoriel = kFactoriel * i;
                }
            }

            BigInteger result = nFactoriel / kFactoriel;
            Console.WriteLine(result);
        }
    }
}
