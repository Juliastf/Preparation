using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            int[] lenghts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = lenghts[0];
            int b = lenghts[1];
            int c = lenghts[2];
            int d = lenghts[3];
            int h = lenghts[4];
            int triangleMax = 0;
            int rectangleMax = 0;
            int rectangleMin = 0;

            int shortestResult = 0;
            int tempGreater = Math.Max(a,b);
            shortestResult += Math.Min(a,b);
            triangleMax = Math.Max(tempGreater, c);
            shortestResult += Math.Min(tempGreater, c);
            rectangleMax = Math.Max(d, h);
            shortestResult += rectangleMax;
            rectangleMin = Math.Min(d, h);
            shortestResult += (2 * rectangleMin);


            if (rectangleMax>triangleMax)
            {
                shortestResult += rectangleMax-triangleMax;
            }
            else if (triangleMax>=rectangleMax)
            {
                shortestResult += triangleMax - rectangleMax;
            }

            Console.WriteLine(shortestResult);



        }
    }
}
