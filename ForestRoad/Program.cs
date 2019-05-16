using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int positionAsterix = 0;

            for (int i = 0; i < 2 * n - 1; i++)
            {

                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == positionAsterix)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }

                    }
                    Console.WriteLine();
                    if (i < n-1)
                    {
                        positionAsterix++;
                    }
                    
                    else
                    {
                        positionAsterix--;
                    }
                }

            }
        }
    }
}
