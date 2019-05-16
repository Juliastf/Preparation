using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            for (int i = number.Length-1; i >=0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
    }
}
