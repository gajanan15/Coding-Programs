using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class FibonacciSeries
    {
        public void FibonacciNumber()
        { 
            int a = 0, b = 1, c;

            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }

            Console.Write(a + " ");

            if (number > 1)
            {
                Console.Write(b + " ");
            }

            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
