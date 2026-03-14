using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class SwapNumberUsingTemp
    {
        public void SwapUsingTemp()
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
        }
    }
}
