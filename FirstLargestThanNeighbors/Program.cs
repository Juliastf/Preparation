using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargestThanNeighbors
{
    class Program
    {
        static void Main()

        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    continue;
                }
                else if (input[i] > input[i - 1] && input[i] > input[i + 1])
                {
                    count++;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (count==0)
            {
                Console.WriteLine("-1");
            }
            
        }
    }
}
