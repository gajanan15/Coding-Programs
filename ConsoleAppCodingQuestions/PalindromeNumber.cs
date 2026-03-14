using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class PalindromeNumber
    {
        public void NUmberPalindrome()
        {
            Console.WriteLine("Enter Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int rev = 0, rem = 0;
            int OriginalNumber = Number;

            while (Number > 0)
            {
                rem = Number % 10;
                rev = rev * 10 + rem;
                Number = Number / 10;
            }

            if (OriginalNumber == rev)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Is Not Palindrome");
            }
        }
    }
}
