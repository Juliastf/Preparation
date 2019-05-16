using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheme
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int biggerNumber = 0;
            int smallerNumber = 0;
            if (x >= y)
            {
                biggerNumber = x;
                smallerNumber = y;

            }
            else
            {
                biggerNumber = y;
                smallerNumber = x;
            }

            String symbol = input[2];

            for (int i = 0; i < smallerNumber; i++)
            {
                for (int j   = 0; j < biggerNumber; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
