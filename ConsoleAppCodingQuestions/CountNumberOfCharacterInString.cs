using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class CountNumberOfCharacterInString
    {
        public void CountCharacter()
        {
            Console.WriteLine("Enter String : ");
            string input = Console.ReadLine().ToLower();
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }
            Console.WriteLine("Character Count in the String:");
            foreach (var item in characterCount)
            {
                Console.WriteLine($"'{item.Key}': {item.Value}");
            }
        }
    }
}
