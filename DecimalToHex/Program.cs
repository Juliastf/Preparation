using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main (string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            String result = "";
            char[] hexNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            do
            {
                result = hexNumbers[(long)n % 16] + result;
                n /= 16;

            } while (n>0);

            Console.WriteLine(result);


        }
    }
}
