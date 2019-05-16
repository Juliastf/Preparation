using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (char.IsDigit(currentSymbol))
                {
                    sum += (currentSymbol - '0');
                    counter++;
                }
            }

            if (counter==0)
            {
                sum = -1;
            }
            Console.WriteLine(sum);

        }
    }
}
