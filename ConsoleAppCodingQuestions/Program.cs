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
            int num;
            bool flag = true;

            while(true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. String Palindrome : ");
                Console.WriteLine("2. Number Palindrome : ");
                Console.WriteLine("3. Armstrong : ");
                Console.WriteLine("4. String Reverse : ");
                Console.WriteLine("5. FibonacciSeries : ");
                Console.WriteLine("\n");
                Console.WriteLine("Which Program You want to Execute : ");
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("You Selected String Palindrome : ");
                        PalindromeString p = new PalindromeString();
                        p.StringPalindrome();
                        break;
                     case 2:
                        Console.WriteLine("You Selected Number Palindrome : ");
                        PalindromeNumber pn = new PalindromeNumber();
                        pn.NumberPalindrome();
                        break;
                     case 3:
                         Console.WriteLine("You Selected Armstrong : ");
                        ArmstrongNumber arm = new ArmstrongNumber();
                        arm.Armstrong();
                        break;
                     case 4:
                        Console.WriteLine("You Selected String Reverse : ");
                        ReverseString sr = new ReverseString();
                        sr.StringReverse();
                        break;
                     case 5:
                        Console.WriteLine("You Selected Fibonacci Series : ");
                        FibonacciSeries fs = new FibonacciSeries();
                        fs.FibonacciNumber();
                        break;
                    default:
                        Console.WriteLine("Please enter correct number.");
                        flag = false;
                        break;

                }
            }
        }
    }
}
