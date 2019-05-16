using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            String[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int yearResult = 0;
            String monthResult = "";
            int dayResult = 0;
            if (day==1)
            {
                if (month==1)
                {
                    dayResult = 31;
                    monthResult = months[11];
                    yearResult = year - 1;
                }
                else if (month==2|| month == 4|| month == 6|| month == 8|| month == 9||month==11)
                {
                    dayResult= 31;
                    monthResult = months[month - 1 - 1];
                    yearResult = year;
                }
                else if (month==3)
                {
                    bool isLeapYear = CheckForLeapYear(year);
                    if (isLeapYear)
                    {
                        dayResult = 29;
                    }
                    else
                    {
                        dayResult = 28;
                    }
                    monthResult = months[1];
                    yearResult = year;
                }
                else if (month == 5 || month == 7 || month == 10 || month == 12)
                {
                    dayResult = 30;
                    monthResult = months[month - 1 - 1];
                    yearResult = year;
                }

            }
            else
            {
                dayResult = day - 1;
                monthResult = months[month - 1];
                yearResult = year;
            }

            Console.WriteLine("{0}-{1}-{2}", dayResult,monthResult, yearResult);

        }

        private static bool CheckForLeapYear(int year)
        {
            bool isLeap = true;
            if (year%4!=0)
            {
                return false;
            }
            return isLeap;
                    
         
        }
    }
}
