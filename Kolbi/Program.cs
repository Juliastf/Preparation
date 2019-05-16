using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kolbi
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(input[0]);
            double volume = double.Parse(input[1]);

            double capacity = 0;

            for (int i = 2; i <=n; i++)
            {
                capacity = (i-1) + capacity;
                if (i%2!=0&&capacity>=volume)
                {
                    Console.WriteLine(i);
                    break;

                }
            }


        }
    }
}
