using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String result = "";
            char[] hexNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };


            for (int i = 0; i < n; i++)
            {
                BigInteger currentNumber = BigInteger.Parse(Console.ReadLine());
                String temp = "";
                do
                {
                    temp = hexNumbers[(long)currentNumber % 16] + temp;
                    currentNumber /= 16;

                } while (currentNumber > 0);
                result += temp;
            }

            int longestSequence = 1;
            int currentSequence = 1;
            int counter = 0;

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] == result[i + 1])
                {
                    currentSequence++;
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                    }
                }
                else
                {
                    currentSequence = 1;
                }
            }

            currentSequence = 1;

            if (longestSequence == 1)
            {
                counter = result.Length;
               
            }
            else
            {
                for (int i = 0; i < result.Length - 1; i++)
                {

                    if (result[i] == result[i + 1])
                    {
                        currentSequence++;

                    }
                    else
                    {
                        currentSequence = 1;
                    }
                    if (currentSequence == longestSequence)
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(longestSequence+" "+counter);

        }
    }
}
