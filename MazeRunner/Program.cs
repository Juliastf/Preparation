using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                char[] inputDigit = Console.ReadLine().ToCharArray();
                int sumEven = 0;
                int sumOdd = 0;
                for (int j = 0; j < inputDigit.Length; j++)
                {
                    int currentNumber = inputDigit[j] - 0;
                    if (currentNumber%2==0)
                    {
                        sumEven += currentNumber;
                    }
                    else
                    {
                        sumOdd += currentNumber;
                    }
                }

                if (sumEven>sumOdd)
                {
                    Console.WriteLine("left");
                }
                else if (sumOdd>sumEven)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("straight");
                }
            }
        }
    }
}
