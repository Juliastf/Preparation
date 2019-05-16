using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];
            int a2b = input[2];
            int b2a = input[3];

            if (a == 0)
            {
                a = CalculateA(b, a2b, b2a);
            }
            if (b == 0)
            {
                b = CalculateB(a, a2b, b2a);
            }

            Console.WriteLine(a+" "+b+" "+a2b+" "+b2a);

            //0 0 0 81
            //1 -9 -9 81
        }

        private static int CalculateB(int a, int a2b, int b2a)
        {
            throw new NotImplementedException();
        }

        private static int CalculateA(int b, int a2b, int b2a)
        {
            int a = -1000;
            if (a2b != 0)
            {
                if (b != 0)
                {
                    a = (int)Math.Sqrt(a2b / b);
                    return a;
                }
                else if (b2a != 0)
                {
                    b = -1000;
                    for (int i = -1000; i <= 1000; i++)
                    {
                        for (int j = -1000; j <= 1000; j++)
                        {
                            if (((int)Math.Sqrt(a2b / b) != b2a / a))
                            {
                                b++;
                            }
                            else
                            {
                                return a;
                            }
                        }
                        a++;
                        b = -1000;

                    }
                }
                else
                {
                    while (Math.Pow(a, 2) * b != a2b)
                    {
                        a++;
                    }
                    return a;

                }
            }
            return a;
        }

    }
}
            