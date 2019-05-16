using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input =BigInteger.Parse(Console.ReadLine());
            
            String[] kaspichanSystem = new string[256];
            char symbol = 'A';

            for (int i = 0; i < 26; i++)
            {
                kaspichanSystem[i] = symbol.ToString();
                symbol++;

            }

            int index = 26;
            symbol = 'a';

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (index < 256)
                    {
                        kaspichanSystem[index] = symbol + kaspichanSystem[j];
                        index++;
                    }

                }
                symbol++;
            }

            //Convert from decimal:
            String sum = "";

            do
            {
                BigInteger remainder = input % 256;
                input = input / 256;
                sum = kaspichanSystem[(int)remainder] + sum;


            } while (input>=0);


            Console.WriteLine(sum);
        }
    }
}
