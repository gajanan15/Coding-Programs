using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class FactorialNumber
    {
        public void Factorial()
        {
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + number + " is : " + factorial);
        }
    }
}
