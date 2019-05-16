using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = tokens[0];
            int k = tokens[1];
            int[] alumni = new int[n+1];

            for (int i = 1; i <= n; i++)
            {
                alumni[i] = int.Parse(Console.ReadLine());
            }

            int movements = k;
            int currentIndex = 0;
            List<int> alumniIndexes = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                alumniIndexes.Add(i);
            }
          
            for (int i = 0; i < n; i++)
            {
                if (alumniIndexes.Count == 1)
                {
                    int winner = alumniIndexes[0];
                    Console.WriteLine(winner);
                    break;
                }


                int indexToBeRemoved = currentIndex + movements - 1;
                indexToBeRemoved = CheckIndexIsInRange(alumniIndexes.Count, indexToBeRemoved);
                movements = alumni[alumniIndexes[indexToBeRemoved]];
                alumniIndexes.RemoveAt(indexToBeRemoved);

                currentIndex = indexToBeRemoved;
                currentIndex = CheckIndexIsInRange(alumniIndexes.Count, currentIndex);

            }
        }

        private static int CheckIndexIsInRange(int length, int index)
        {
            while (index >= length)
            {
                index = index - length;
            }

            return index;
        }
    }
}
