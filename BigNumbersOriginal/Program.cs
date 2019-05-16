using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumbersOriginal
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            int temp = 0;
            

            for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
            {
                if (i < Math.Min(first.Length, second.Length))
                {

                    int currentSum = first[i] + second[i] + temp;
                    if (currentSum > 9)
                    {
                        result.Add(currentSum % 10);
                        temp = 1;
                    }
                    else
                    {
                        result.Add(currentSum);
                        temp = 0;
                    }
                }
                else if (first.Length > second.Length && i >= second.Length)
                {
                    int tempResult = first[i] + temp;
                    if (tempResult>9)
                    {
                        result.Add(tempResult%10);
                        temp = 1;

                    }
                    else
                    {
                        result.Add(tempResult);
                        temp = 0;
                    }
                        
                    
                }
                else if (second.Length > first.Length && i >= first.Length)
                {
                    int tempResult = second[i] + temp;
                    if (tempResult > 9)
                    {
                        result.Add(tempResult % 10);
                        temp = 1;

                    }
                    else
                    {
                        result.Add(tempResult);
                        temp = 0;
                    }

                }
            }

            if (temp == 1)
            {
                result.Add(1);
            }

            Console.WriteLine(String.Join(" ", result.ToArray()));

        }
    }
}
