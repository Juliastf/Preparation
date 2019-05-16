using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

           
            int sum = 0;
            int maxSum = 0;


            for (int i = 0; i < n; i++)
            {
                sum = input[i];
                for (int j = i + 1; j < n; j++)
                {
                    sum += input[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                   
                }
                sum = 0;

            }
            Console.WriteLine(maxSum);
        }
    }
}
