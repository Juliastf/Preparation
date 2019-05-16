using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestPrimeNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = (int)Math.Sqrt(n); i >1; i--)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i%j!=0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(prime);
                    break
                }
            }
        }
    }
}
