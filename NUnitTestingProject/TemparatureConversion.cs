using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class TemparatureConversion
    {
        public void CelsiusToFahrenhiet()
        {
            Console.WriteLine("Enetr the Temparature in Celsius to Convert: ");
            int celsius = Convert.ToInt32(Console.Read());
            float fahrenhiet = ((float)celsius * 9 / 5) + 32;
            Console.WriteLine("Converted Temparature is:->" + fahrenhiet + "F");
        }
        public void FahrenhietToCelsius()
        {
            Console.WriteLine("Enetr the Temparature in Fahrenheit to Convert: ");
            int fahrenhiet = Convert.ToInt32(Console.Read());
            float celsius = (float)((fahrenhiet - 32) * 5 / 9);
            Console.WriteLine("Converted Temparature is:->" + celsius + "C");
        }
    }

}

