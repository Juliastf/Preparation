using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            int startPosition = 1;
            int nextPosition = 2;
            int currentNumber = 2;


            for (int i = 0; i < n; i++)
            {
                Console.Write(startPosition);
                for (int j = 0; j < k - 1; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine();
                if (currentNumber<n)
                {
                    
                    currentNumber--;
                }
                else
                {

                }

                nextPosition++;
                if (nextPosition == n)
                {
                    startPosition++;
                    nextPosition = startPosition +1;
                }
                
                currentNumber = nextPosition;

            }
        }
    }
}
