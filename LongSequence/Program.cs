using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class Program
    {
        static void Main()
        {
            int positiveNumber = 2;
            int negativeNumber = -3;

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(positiveNumber);
                Console.WriteLine(negativeNumber);
                positiveNumber += 2;
                negativeNumber -= 2;
            }
        }
    }
}
