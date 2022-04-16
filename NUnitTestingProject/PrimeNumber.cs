using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class PrimeNumber
    {
        int count = 0;
        public void Prime()
        {
            Console.WriteLine("Enter the Number to Check Number is Prime or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    if (count > 2)
                    {
                        break;
                    }
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Given Number is Prime:" + " " + num);
            }
            else
                Console.WriteLine("Given Number is not prime" + " " + num);
        }

    }
}
