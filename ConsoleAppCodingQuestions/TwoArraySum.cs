using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodingQuestions
{
    internal class TwoArraySum
    {
        /*
            input : arr1 = [1, 2, 3], arr2 = [4,8,4];
            output : [5,0,8]
         */
        public void TwoArraysSumWithCarry()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 8, 4 };
            int carry = 0;
            int[] res = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                int sum = arr1[i] + arr2[i] + carry;
                res[i] = sum % 10;
                carry = sum / 10;
            }

            for(int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
        
    }
}
