using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SignalfromSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <input.Length; i++)
            {
                result.Append(input[i - 1]);
                while (i<input.Length&&input[i - 1] == input[i])
                {
                    i++;
                }
                if (i==input.Length-1)
                {
                    result.Append(input[i ]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
