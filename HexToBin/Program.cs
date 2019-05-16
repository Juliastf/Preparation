using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBin
{
    class Program
    {
        static void Main()
        {
            String input = Console.ReadLine();
            String[] hexSystem = new String[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B","C","D","E","F"};
            StringBuilder result = new StringBuilder();
           

            if (input.Length== 1 && input[0] == '0')
            {
                Console.WriteLine("0000");
                return;
            }
                for (int i = 0; i < input.Length; i++)
            {
                String symbol = input[i].ToString().ToUpper();
                int current = Array.IndexOf(hexSystem, symbol);
                    String tempNumber = "";

                for (int j = 0; j < 4; j++)
                {
                    if (i==0&&current==0)
                    {
                        break;
                    }
                    int converted = current % 2;
                    tempNumber = converted.ToString() + tempNumber;
                    current /= 2;
                   
                }
               


               result.Append(tempNumber);
            }

            Console.WriteLine(result.ToString());


        }
    }
}
