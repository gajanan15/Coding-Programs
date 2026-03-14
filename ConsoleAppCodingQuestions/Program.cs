using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. String Palindrome : ");
            Console.WriteLine("Which Program You want to Execute : ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("You Selected String Palindrome : ");
                    PalindromeString p = new PalindromeString();
                    p.StringPalindrome();
                    
                    break;
                default: 
                     Console.WriteLine("Please enter correct number.");
                    break;

            }

        }
    }
}
