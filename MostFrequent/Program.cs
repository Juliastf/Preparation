using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequent
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            for (int i = 0; i < n; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            int counter = 1;
            int maxTimes = 0;
            int mostFrequent = 0;

            input.Sort();

            for (int i = 0; i < n-1; i++)
            {
                if (input[i]==input[i+1])
                {
                    counter++;
                    if (counter>maxTimes)
                    {
                        maxTimes = counter;
                        mostFrequent = input[i];
                    }

                }
                else
                {
                    counter = 1;
                }

            }
            

            Console.WriteLine("{0} ({1} times)",mostFrequent, maxTimes);
        }
    }
}
