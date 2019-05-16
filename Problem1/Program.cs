using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = int.Parse(number[i].ToString());

                if (currentNumber%2==0)
                {
                    evenSum += currentNumber;
                }
                else 
                {
                    oddSum += currentNumber;
                }
            }

            if (evenSum>oddSum)
            {
                Console.WriteLine(evenSum+" energy drinks");
            }
            else if (oddSum>evenSum)
            {
                Console.WriteLine(oddSum + " cups of coffee");

            }
            else
            {
                Console.WriteLine(evenSum+" of both" );
            }
        }
    }
}
