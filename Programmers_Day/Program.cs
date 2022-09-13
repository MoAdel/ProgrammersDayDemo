using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    Console.WriteLine("Enter a year: ");
                    int year = int.Parse(Console.ReadLine());

                    if (year > 1700 && year < 2700)
                    {
                        Console.WriteLine("Programmers Day of this year at : " + Programmers_Day(year));
                    }
                    else
                    {
                        Console.WriteLine("number is out of Range");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Paramter");
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static string Programmers_Day(int year)
        {
            int day;
            if (year < 1918)
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    day = 12;
                }
                else
                {
                    day = 13;
                }
            }
            else if (year == 1918)
            {
                day = 26;
            }
            else
            {
                if (year % 4 == 0)
                {
                    day = 12;
                }
                else
                {
                    day = 13;
                }
            }
            string _date = new DateTime(year, month:09, day).ToString("dd.MM.yyyy");
            return _date;
        }
    }
}
