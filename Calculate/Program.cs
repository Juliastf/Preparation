using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            long factoriel = 1;
            double sum = 1;

            for (int i = 01; i <= n; i++)
            {
                factoriel = factoriel * i;
                sum += factoriel / (Math.Pow(x, i));
            }

            Console.WriteLine("{0:F5}",sum);


        }
    }
}
