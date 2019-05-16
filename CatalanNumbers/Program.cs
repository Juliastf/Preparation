using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;
            BigInteger nFactoriel2 = 1;
            BigInteger nPlus1Factoriel = 1;

            for (int i = 2; i <= 2*n; i++)
            {
                nFactoriel2 = i * nFactoriel2;
                if (i==n)
                {
                    nFactoriel = nFactoriel2;
                }
                if (i==n+1)
                {
                    nPlus1Factoriel = nFactoriel2;
                }

            }

            Console.WriteLine("{0}",nFactoriel2/(nPlus1Factoriel*nFactoriel));

        }
    }
}
