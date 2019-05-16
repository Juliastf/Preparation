using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                bool isSymetrical = true;

                for (int j  = 0; j < input.Length/2; j++)
                {
                    if (input[j] != input[input.Length-1-j])
                    {
                        isSymetrical = false;
                        break;
                    }
                }

                if (isSymetrical)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
