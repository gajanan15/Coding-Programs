using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class CheckPrimeNumber
    {
        public void CheckPrime()
        {
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 1)
            {
                Console.WriteLine(number + " is not a prime number.");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + " is not a prime number.");
                    return;
                }
            }
            Console.WriteLine(number + " is a prime number.");
        }
    }
}
