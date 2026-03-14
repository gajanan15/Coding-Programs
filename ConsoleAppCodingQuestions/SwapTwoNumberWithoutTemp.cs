using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class SwapTwoNumberWithoutTemp
    {
        public void SwapWithoutTemp()
        {
            Console.WriteLine("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b; // num1 now holds the sum of num1 and num2
            b = a - b; // num2 now holds the original value of num1
            a = a - b; // num1 now holds the original value of num2
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);
        }
    }
}
