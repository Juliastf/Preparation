using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class Program
    {
        static void Main()
        {
            int[] cats = new int[10];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                cats[vote-1] += 1;
            }

            int indexMax = 0;

            for (int i = 0; i < cats.Length; i++)
            {
                if (cats[i]>cats[indexMax])
                {
                    indexMax = i;
                }
            }

            Console.WriteLine(indexMax+1);
        }
    }
}
