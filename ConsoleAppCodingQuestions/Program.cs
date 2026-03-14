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
                Console.WriteLine("6. Largest Number In Array : ");
                Console.WriteLine("7. Factorial Number : ");
                Console.WriteLine("8. Anagram Using Dictionary : ");
                Console.WriteLine("9. Check Anagram : ");
                Console.WriteLine("10. Check Prime Number : ");
                Console.WriteLine("11. Swap Number Using Temp : ");
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
                    case 6:
                        Console.WriteLine("You Selected Largest Number In Array : ");
                        LargestNumberInArray largestNumberInArray = new LargestNumberInArray();
                        largestNumberInArray.LargestNumber();
                        break;
                    case 7:
                        Console.WriteLine("You Selected Factorial Number : ");
                        FactorialNumber FactorialNumber = new FactorialNumber();
                        FactorialNumber.Factorial();
                        break;
                    case 8:
                        Console.WriteLine("You Selected Anagram Using Dictionary : ");
                        AnagramUsingDictionary anagramUsingDictionary = new AnagramUsingDictionary();
                        anagramUsingDictionary.Anagram();
                        break;
                    case 9:
                        Console.WriteLine("You Selected Check Anagarm : ");
                        CheckAnagarm checkAnagarm = new CheckAnagarm();
                        checkAnagarm.CheckAnagram();
                        break;
                    case 10:
                        Console.WriteLine("You Selected Check Prime Number : ");
                        CheckPrimeNumber checkPrimeNumber = new CheckPrimeNumber();
                        checkPrimeNumber.CheckPrime();
                        break;
                    case 11:
                        Console.WriteLine("You Selected Swap Number Using Temp : ");
                        SwapNumberUsingTemp swapNumberUsingTemp = new SwapNumberUsingTemp();
                        swapNumberUsingTemp.SwapUsingTemp();
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
