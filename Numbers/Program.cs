using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            List<String> input = new List<string>();
            string newLine = "";
            while (newLine != "end")
            {
                newLine = Console.ReadLine();
                input.Add(newLine);

            }


            String number = "";
            for (int i = 0; i < input.Count; i++)
            {
                String[] command = input[i].Split(' ').ToArray();
                switch (command[0])
                {
                    case "set":
                        number = command[1];
                        break;
                    case "front-add":
                        number = command[1] + number;
                        break;
                    case "front-remove":
                        if (number.Length > 0)
                        {
                            int startIndex = 1;
                            number = number.Substring(startIndex);
                        }
                        break;
                    case "back-add":
                        number = number + command[1];
                        break;
                    case "back-remove":
                        if (number.Length > 0)
                        {
                            
                            int endIndex = number.Length - 1;
                            number = number.Remove(endIndex);
                        }
                        break;
                    case "reverse":
                        char[] reversed = number.ToCharArray();
                        Array.Reverse(reversed);
                        number = new string(reversed);
                        break;
                    case "print":
                        Console.WriteLine(number);
                        break;

                }



            }


        }
    }
}
