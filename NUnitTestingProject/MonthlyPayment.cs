using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class MonthlyPayment
    {
        public void PaymentMonthly()
        {
            Console.WriteLine("Enter the Principle Value, Rate Of Interest, And Time In Year ");
            double principle_value = Convert.ToDouble(Console.ReadLine());
            double rate_Of_Interest = Convert.ToDouble(Console.ReadLine());
            double time_In_Year = Convert.ToDouble(Console.ReadLine());
            double r = rate_Of_Interest / (12 * 100);
            double n = time_In_Year * 12;
            double p = principle_value;
            double payment = p * r / (1 - Math.Pow((double)(1 + r), -n));
            Console.WriteLine("Monthly payment is:--->"+payment);
        }
    }
}
