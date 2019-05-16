using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 0;
            int multiplier = 2;
            int pow = 0;

            do
            {
                result = (input % 10)*(long)Math.Pow(multiplier,pow)+result ;
                input /= 10;
                
                pow++;

            } while (input>0);

            Console.WriteLine(result);
        }
    }
}
