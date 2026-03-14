using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class PalindromeString
    {
        public void StringPalindrome() 
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            { 
                rev += str[i];
            }

            if (rev == str)
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
