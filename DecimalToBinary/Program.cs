using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            string sum = "";

            if (n==0)
            {
                sum += 0;
            }
            while (n >0) 
            {
                sum = n % 2 + sum;
                n /= 2;
            }
            Console.WriteLine(sum);
        }
    }
}
