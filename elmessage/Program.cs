using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elmessage
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol == '.')
                {
                    break;
                }
                if (!char.IsLetterOrDigit(currentSymbol) && currentSymbol != ' ')
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }


                    count = 0;
                }

               
            }
            if (count > maxCount)
            {
                maxCount = count;
            }



            Console.WriteLine(maxCount);
        }
    }
}
