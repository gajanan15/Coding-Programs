using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class CheckAnagarm
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter String 1 : ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter String 2 : ");
            string str2 = Console.ReadLine();
            if (str.Length != str2.Length)
            {
                Console.WriteLine("Not Anagram");
                return;
            }
            char[] charArray1 = str.ToLower().ToCharArray();    
            char[] charArray2 = str2.ToLower().ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);
            if (charArray1.SequenceEqual(charArray2))
            {
                Console.WriteLine("Is Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
