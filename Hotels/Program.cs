using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] hotels = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int viewFromLeft = 1;
            int viewFromRight = 1;

            if (n==0)
            {
                Console.WriteLine(0);
                return;
            }

            int lastSeen = 0;
            
            for (int i = 0; i < hotels.Length-1; i++)
            {

                if (hotels[lastSeen] <hotels[i+1])
                {
                    viewFromLeft++;
                    lastSeen = i + 1;
                
                }
                else if (hotels[lastSeen] ==hotels[i + 1])
                {
                    continue;
                }
              
                else if(hotels[lastSeen] < hotels[i + 1])
                {
                    continue;
                }
            }

            lastSeen = hotels.Length-1;

            for (int i = hotels.Length-1; i >0; i--)
            {
                if (hotels[lastSeen] < hotels[i - 1])
                {
                    viewFromRight++;
                    lastSeen= i - 1;
                }
                else if (hotels[lastSeen] == hotels[i - 1])
                {
                    continue;
                }
                else if (hotels[lastSeen] > hotels[i - 1])
                {
                    continue;
                }
            }

            Console.WriteLine(viewFromLeft+" "+viewFromRight);
        }
    }
}
