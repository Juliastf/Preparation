using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigNumbers
{
    class Program
    {
        static void Main()
        {
           


            int n = int.Parse(Console.ReadLine());

            //String input = Console.ReadLine();

            //input = input.Replace(" ", "");

            List<char> input = new List<char>();
            while (true)
            {
                char ch = Convert.ToChar(Console.Read());
                if (ch == ' ')
                {
                    continue;
                }
                input.Add(ch);
                if (ch == '\n')
                {
                    break;
                }

            }

            int firstIndex = 0;
            int lastIndex = 0;
            bool isPalindrome = true;
            String result = "";
            BigInteger biggestPalindrome = 0;
            int inputLength = input.Count;

            for (int i = 0; i < inputLength - 1; i++)
            {
                if (input[i] == '0')
                {
                    continue;
                }
                else
                {
                    for (int j = inputLength - 1; j > i; j--)
                    {

                        if (input[i] == input[j] && (j - i + 1) >= result.Length)
                        {
                            firstIndex = i;
                            lastIndex = j;


                            //string palindrome = input.ToString(firstIndex, lastIndex - firstIndex + 1);

                            isPalindrome = CheckIfPalindrome2(firstIndex, lastIndex, input);
                            if (isPalindrome)
                            {
                                StringBuilder palindrome = new StringBuilder();
                                for (int k = firstIndex; k <= lastIndex; k++)
                                {
                                    palindrome.Append(input[k]);
                                }
                                string pal = palindrome.ToString();

                                if (isPalindrome && BigInteger.Parse(pal) > biggestPalindrome)
                                {
                                    result = pal;
                                    biggestPalindrome = BigInteger.Parse(pal);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(biggestPalindrome);

        }




        private static bool CheckIfPalindrome2(int firstIndex, int lastIndex, List<char> input)
        {
            int length = (lastIndex - firstIndex + 1);
            for (int i = 0; i < length / 2; i++)
            {
                if (input[firstIndex] == input[lastIndex])
                {
                    firstIndex++;
                    lastIndex--;
                }
                else
                {
                    return false;

                }
            }
            return true;
        }

    }
}

