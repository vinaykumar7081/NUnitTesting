using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class FibbonacciSeries
    {
        int first_Num = 0, second_Num = 1, third_Num;
        public void Fibbonacci()
        {

            Console.WriteLine("Enter the length of the Series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibbonacci Siries is:->");
            Console.Write(" " + first_Num);
            Console.Write(" " + second_Num);
            for (int i = 1; i <= num; i++)
            {
                third_Num = first_Num + second_Num;
                Console.Write(" " + third_Num);
                first_Num = second_Num;
                second_Num = third_Num;
            }
            Console.WriteLine(" ");
        }
    }
}
