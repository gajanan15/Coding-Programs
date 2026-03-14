using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class AnagramUsingDictionary
    {
        public void Anagram()
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

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            foreach (char c in str2)
            {
                if (!dict.ContainsKey(c))
                {
                    Console.WriteLine("Not Anagram");
                    return;
                }

                dict[c]--;

                if (dict[c] == 0)
                { 
                    dict.Remove(c);
                }
            }

            if (dict.Count == 0)
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
