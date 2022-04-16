using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProject
{
    public class SquareRootOfNumber
    {
        public void SquareRoot()
        {
            Console.WriteLine("Enter the Positive Number");
            int number=Convert.ToInt32(Console.ReadLine());
            double root = Math.Sqrt(number);
            Console.WriteLine("Square root of the number is :--->" + root);
        }
    }
}
