using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddorEvenProduct
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long productOdd = 1;
            long productEven = 1;
            for (int i = 0; i < n; i++)
            {
                if (i%2!=0)
                {
                    productOdd *= input[i];
                }
                else
                {
                    productEven *= input[i];
                }
            }

            if (productOdd==productEven)
            {
                Console.WriteLine("yes {0}",productEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}",productEven,productOdd);
            }
        }
    }
}
