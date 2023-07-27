using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_the_Number_of_Vowel_Strings_in_Range
    {
        public int VowelStrings(string[] words, int left, int right)
        {
            int count = 0;
            for(int i= left; i<=right; i++)
            {
                if (VowelCheck(words[i][0]) && VowelCheck(words[i][words[i].Length -1]))
                    count++;
                
            }
            return count;
        }

        private bool VowelCheck(char value)
        {
            return value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u';
        }
    }
}
