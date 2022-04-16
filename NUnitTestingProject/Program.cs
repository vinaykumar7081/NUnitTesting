using System;
using NUnitTestingProject;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ********* Welcome in The Basic Logical Programming World ********");
        bool check = true;
        while (check)
        {
            Console.WriteLine(" Enter Zero To Stop The Excution 0\n Dispaly FibbonacciSeries 1\n Display Perfect Number 2\n Checking Prime or Not 3\n Reversig Number 4\n Day Of Week 5\n Temparature Conversion 6\n Monthly Payment 7\n");
            Console.WriteLine("Enter the Above Option");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibbonacciSeries  series = new FibbonacciSeries();
                    series.Fibbonacci();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.Perfect();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                case 4:
                    ReverseNumber  reverse = new ReverseNumber();
                   reverse .NumberReversing ();
                    break;
                case 5:
                    DisplayDayOfWeek  day = new DisplayDayOfWeek();
                    day.DayOfWeek();
                    break;
                case 6:
                    TemparatureConversion  temparature = new TemparatureConversion();
                    temparature.CelsiusToFahrenhiet ();
                    temparature.FahrenhietToCelsius ();
                    break;
                case 7:
                    MonthlyPayment payment = new MonthlyPayment();
                    payment.PaymentMonthly ();
                    break;
                case 0:

                   check = false;
                    break;
            }
        }
    }
}