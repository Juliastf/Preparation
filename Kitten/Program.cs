using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitten
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] path = Console.ReadLine().ToCharArray();
            int[] movements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int jumps =0;
            int coderSouls =0;
            int food =0;
            int deadlocks = 0;
            int position = 0;

            for (int i = 0; i <= movements.Length; i++)
            {
                char currentField = path[position];
                if (currentField == '@')
                {
                    coderSouls++;
                    path[position] = '0';
                }
                else if ((currentField == '*'))
                {
                    food++;
                    path[position] = '0';
                }
                else if ((currentField == 'x'))
                {
                    if (position%2==0)
                    {
                        coderSouls--;
                        deadlocks++;
                        path[position] = '@';
                    }
                    else
                    {
                        food--;
                        deadlocks++;
                        path[position] = '*';
                    }
                    if (food<0||coderSouls<0)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumps);
                        break;
                    }
                    
                }
                jumps++;
                

                if (i<movements.Length)
                {                
                    int moves = movements[i];
                    if (moves >= 0)
                    {
                        while ((position + moves) > path.Length - 1)
                        {
                            moves -= path.Length;
                        }
                        position += moves;
                    }
                    else if (moves < 0)
                    {
                        while ((position + moves) < 0)
                        {
                            moves = path.Length + moves;
                        }
                        position += moves;
                    }
                }
                else
                {
                    Console.WriteLine("Coder souls collected: {0} \nFood collected: {1} \nDeadlocks: {2}", coderSouls, food, deadlocks);
                }
            }

           






        }
    }
}
