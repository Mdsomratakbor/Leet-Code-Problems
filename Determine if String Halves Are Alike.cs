using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Determine_if_String_Halves_Are_Alike
    {
        public bool HalvesAreAlike(string s)
        {
            s = s.ToLower();
            int firstHalfVowel = 0, secondHalfVowel = 0, left = 0, half = 0, right = 0, length = 0;

            length = s.Length;
            right = length - 1;
            half = length / 2;

            while (left<half &&  right>=half)
            {
                if (s[left] == 'a' || s[left] == 'e' || s[left] == 'i' || s[left] == 'o' || s[left] == 'u')
                    firstHalfVowel++;
                if (s[right] == 'a' || s[right] == 'e' || s[right] == 'i' || s[right] == 'o' || s[right] == 'u')
                    secondHalfVowel++;
                left++;
                right--;
            }


            return firstHalfVowel == secondHalfVowel;
        }
    }
}
