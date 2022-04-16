using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class DisplayDayOfWeek
    {
        int day, year, month;
        public void DayOfWeek()
        {
            Console.WriteLine("Please Enter the number of Days");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the number of Month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());
            int year0 = year - (14 - month) / 12;
            int leapyear = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + (leapyear * month0) / 12) % 7;
            switch (day0)
            {
                case 0:
                    Console.WriteLine("Sunaday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("TuseDay");
                    break;
                case 3:
                    Console.WriteLine("WednesDay");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
