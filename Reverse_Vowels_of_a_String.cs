using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reverse_Vowels_of_a_String
    {
        public string ReverseVowels(string s)
        {
            var sArray = s.ToArray();
            int left = 0;
            int right = s.Length - 1;
            char temp = ' ';
            while (left<right)
            {
                while (left < right && !IsVowel(s[left]))
                {
                    left++;
                }
                while (left < right && !IsVowel(s[right]))
                {
                    right--;
                }

                if (IsVowel(s[left]) && IsVowel(s[right]))
                {
                    temp = s[left];
                    sArray[left] = sArray[right];
                    sArray[right] = temp;
                }
                left++;
                right--;
            }
            string newFormat = new string(sArray);
            return newFormat;
        }
        static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                   c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
}
