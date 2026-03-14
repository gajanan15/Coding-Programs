using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class SwapThreeNumberWithoutusing3rdvariable
    {
        public void SwapThreeNumberWithoutTemp()
        {
            Console.WriteLine("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            a = a + b + c; // a now holds the sum of a, b, and c
            b = a - (b + c); // b now holds the original value of a
            c = a - (b + c); // c now holds the original value of b
            a = a - (b + c); // a now holds the original value of c
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);
            Console.WriteLine("Third Number : " + c);
        }
    }
}
