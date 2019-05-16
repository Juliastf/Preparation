using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculate3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;
            int differance = n - k;
            BigInteger diffFactoriel = 1;

            for (int i = 2; i <= n; i++)
            {
                nFactoriel = i * nFactoriel;
                if (i<=k)
                {
                    kFactoriel = i * kFactoriel;
                }
                if (i==differance)
                {
                    diffFactoriel = nFactoriel;
                }

            }

            BigInteger result = nFactoriel / (kFactoriel * diffFactoriel);
            Console.WriteLine(result);
        }

    }
}
