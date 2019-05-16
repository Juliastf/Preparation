using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            String n = input[0];
            int k = int.Parse(input[1]);
            string newNumberAsString = "";

            for (int i = 0; i < n.Length / 2; i++)
            {
                newNumberAsString += n[n.Length - 1 - i];
            }
            for (int i = n.Length / 2 - 1; i >= 0; i--)
            {
                newNumberAsString += n[i];
            }

            int newNumber = int.Parse(newNumberAsString);
            int remainder = newNumber % k;
            int quotient = newNumber / k;
            int result = remainder + quotient;
            Console.WriteLine(result);

        }
    }
}
