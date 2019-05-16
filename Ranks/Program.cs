using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int temp = 0;
            int[] result = input.ToArray();


            for (int i = 0; i < n; i++)
            {
               
                for (int j = i + 1; j < n; j++)
                {
                    if (i<n &&result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                        
                        
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                int nToRank = input[i];
                int rank =n- Array.IndexOf(result, nToRank);
                Console.Write(rank+" ");
        }
            
        }
    }
}
