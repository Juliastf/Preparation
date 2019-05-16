using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixofNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int numberToPrint = firstNumber;
                while (counter<n)
                {
                    Console.Write(numberToPrint + " ");
                    numberToPrint++;
                    counter++;
                }
                Console.WriteLine();
                counter = 0;
                firstNumber++;
                    
                
            }
        }
    }
}
