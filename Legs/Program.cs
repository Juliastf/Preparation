using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legs
{
    class Program
    {
        static void Main()
        {
            int numberOfLegs = int.Parse(Console.ReadLine());
            
           
            
            int combinations = 0;

            for (int chicken = 0; chicken <= numberOfLegs; chicken += 7)
            {
                for (int bears = 0; bears <= numberOfLegs; bears += 2)
                {
                    for (int humans = 0; humans <= numberOfLegs; humans += 5)
                    {
                        if (chicken + bears + humans == numberOfLegs)
                        {
                            combinations++;
                        }
                    }
                }

            }

            Console.WriteLine(combinations);

        }
    }
}
