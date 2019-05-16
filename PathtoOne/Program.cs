using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathtoOne
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countOperations = 0;



            while (true)
            {
                if (n==1)
                {
                    Console.WriteLine(countOperations);
                    break;
             
                }
                if (n % 2 == 0)
                {
                    n = n / 2;
                    countOperations++;
                    continue;
                }

                
                if ((n - 1)/2 % 2 == 0 || n == 3) 
                {
                    n -= 1;
                    countOperations++;
                }
                else if ((n + 1)/2 % 2 == 0)
                {
                    n += 1;
                    countOperations++;
                }

            }

         


        }
    }
}
