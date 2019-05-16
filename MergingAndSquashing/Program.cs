using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingAndSquashing
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

            for (int i = 0; i < n - 1; i++)
            {
                int first = input[i] % 10;
                int second = input[i + 1] / 10;


                Console.Write(first.ToString()+ second.ToString()+ " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                int firstToAdd = input[i] % 10;
                int secondToAdd = input[i + 1] / 10;
                int third = firstToAdd + secondToAdd;
                if (third>9)
                {
                    third = third % 10;
                }
                int first = input[i] / 10;
                int second = input[i + 1] % 10;

                Console.Write(first.ToString() + third.ToString()+second.ToString() + " ");
            }
            Console.WriteLine();

        }
    }
}
