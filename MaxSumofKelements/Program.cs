using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumofKelements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            for (int i = 0; i < n; i++)
            {
                input[i] =int.Parse(Console.ReadLine());
            }

            Array.Sort(input);
            
           
            int maxSum = 0;
            

            for (int i = n-1; i > n-1-k; i--)
            {
                maxSum += input[i];

            }
            Console.WriteLine(maxSum);
        }
    }
}
