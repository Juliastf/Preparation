using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = input.Length-1; i >= 0; i--)
            {
                if (char.IsLetter(input[i]))
                {
                    result.Append(input[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
