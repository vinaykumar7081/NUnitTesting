using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class PerfectNumber
    {
        int sum = 0;
        public void Perfect()
        {
            Console.WriteLine("Enter a Number To check Number is perfect or Not");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("Given Number is Perfect Number :" + " " + sum);
            }
            else
            {
                Console.WriteLine("Given Number is mot perfect Number :" + " " + sum);
            }
        }
     }
}
