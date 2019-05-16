using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    class Program
    {
        static void Main()
        {
            String[] input = Console.ReadLine().Split(' ').ToArray();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int counter = 0;

            for (int i = a; i <= b; i++)

            {
                bool isGoodNumber = CheckTheNumber(i);

                if (isGoodNumber)
                {
                    counter++;
                }

            }

            Console.WriteLine(counter);
        }

        private static bool CheckTheNumber(int i)
        {
            int number = i;
            while (number > 0)
            {

                int n1 = number % 10;

                if (n1 == 0)
                {
                    number = number / 10;
                    continue;
                }
                else if (i % n1 != 0)
                {
                    return false;

                }
                number = number / 10;

            }

            return true;



        }
    }
}
