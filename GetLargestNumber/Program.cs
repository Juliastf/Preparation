using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxValue = GetMaxValue(input);
            Console.WriteLine(maxValue);
        }

        private static int GetMaxValue(int[] input)
        {
            int first = input[0];
            int second = input[1];
            int third = input[2];

            if (first>=second&&first>=third)
            {
                return first;
            }
            else if (second>=first&&second>=third)
            {
                return second;
            }
            else 
            {
                return third;
            }
        }
    }
}
