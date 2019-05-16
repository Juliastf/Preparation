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
            
            StringBuilder input = new StringBuilder();
            while (true)
            {
                char ch = Convert.ToChar(Console.Read());
                if (ch == ' ')
                {
                    continue;
                }
                input.Append(ch);
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

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '0')
                {
                    continue;
                }
                else
                {
                    for (int j = input.Length - 1; j > i; j--)
                    {

                        if (input[i] == input[j] && (j - i + 1) >= result.Length)
                        {
                            firstIndex = i;
                            lastIndex = j;
                            string palindrome = input.ToString(firstIndex, lastIndex - firstIndex + 1);

                            isPalindrome = CheckIfPalindrome(palindrome, palindrome.Length);
                            if (isPalindrome && BigInteger.Parse(palindrome) > biggestPalindrome)
                            {
                                result = palindrome;
                                biggestPalindrome = BigInteger.Parse(palindrome);
                            }
                        }
                    }
                }
            }

            Console.WriteLine(biggestPalindrome);



        }

        private static bool CheckIfPalindrome(string palindrome, int length)
        {
            //string firstHalf = palindrome.Substring(0, (palindrome.Length / 2)-1);
            //string secHalf = palindrome.Substring((palindrome.Length / 2),);

            for (int i = 0; i < length / 2; i++)
            {

                if (palindrome[i] == palindrome[length - 1 - i])
                {
                    continue;
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
