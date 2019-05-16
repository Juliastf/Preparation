using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = i * 5;
                Console.WriteLine(result[i]);
            }

           

        }
    }
}
