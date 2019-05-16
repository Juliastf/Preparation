using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    class Program
    {
        static void Main()

        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];

            if (a>=b)
            {
                Console.WriteLine(a-b);
            }
            else
            {
                Console.WriteLine(b-a);
            }



        }
    }
}
