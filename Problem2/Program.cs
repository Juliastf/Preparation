using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            string commands = Console.ReadLine();
            int x = 0;
            int y = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                char currentCommant = commands[i];

                if (currentCommant=='U')
                {
                    y++;
                }
                else if (currentCommant=='D')
                {
                    y--;
                }
                else if (currentCommant=='R')
                {
                    x++;
                }
                else if (currentCommant=='L')
                {
                    x--;
                }
            }

            Console.WriteLine("("+x+", "+y+")");
        }
    }
}
