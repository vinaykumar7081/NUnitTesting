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
            Console.WriteLine(" Enter Zero To Stop The Excution 0\n Dispaly FibbonacciSeries 1\n");
            Console.WriteLine("Enter the Above Option");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibbonacciSeries  series = new FibbonacciSeries();
                    series.Fibbonacci();
                    break;
                case 0:
                   check = false;
                    break;
            }
        }
    }
}