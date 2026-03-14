using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class ArmstrongNumber
    {
        public void Armstrong()
        {
            Console.WriteLine("Enter Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int rem = 0, sum = 0;
            int OriginalNumber = Number;
            while (Number > 0)
            {
                rem = Number % 10;
                sum = sum + (rem * rem * rem);
                Number = Number / 10;
            }
            if (OriginalNumber == sum)
            {
                Console.WriteLine("Is Armstrong");
            }
            else
            {
                Console.WriteLine("Is Not Armstrong");
            }
        }
    }
}
