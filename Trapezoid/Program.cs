using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int startPos = 2*n - n;
            int endPos = 2*n - 1;

            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < 2*n; j++)
                {
                    if (j == startPos)
                    {
                        Console.Write("*");
                    }
                    else if (j == endPos) 
                    {
                        Console.Write("*");
                    }
                    else if (j > startPos&&(i==0||i==n))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                startPos--;
            }
        }
    }
}
