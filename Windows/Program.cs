using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int price = input[1];
            int numberOfWindows = input[0];
            int area = 0;

            for (int i = 0; i < numberOfWindows; i++)
            {
                int[] window = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (window[2]==0)
                {
                    continue;
                }
                area += (window[0] * window[1]);

            }

            Console.WriteLine(area*price);
        }
    }
}
