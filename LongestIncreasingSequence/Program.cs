using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int maxSequence = 1;
            int sequence = 1;

            for (int i = 0; i < n; i++)
            {
                if ((i + 1) < n)
                {
                    if (input[i] <input[i + 1])
                    {
                        sequence++;
                        if (sequence > maxSequence)
                        {
                            maxSequence = sequence;
                        }
                    }
                    else
                    {
                        sequence = 1;
                    }

                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}

