using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public  class ReverseNumber
    {
        int rem = 0 ,sum=0;
        public void NumberReversing()
        {
            Console.WriteLine("Enter a Number to reversing");
            int number=Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                rem = number % 10;
                sum = sum * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("Reverse numbere is:--->"+sum);
        }
    }
}
