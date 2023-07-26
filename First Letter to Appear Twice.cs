using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class First_Letter_to_Appear_Twice
    {
        public char RepeatedCharacter(string s)
        {
            char c = ' ';
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (charCounts.ContainsKey(currentChar))
                {
                    charCounts[currentChar]++;
                }
                else
                {
                    charCounts[currentChar] = 1;
                }
                if (charCounts[currentChar] >= 2)
                {
                    return currentChar;
                }
            }
            return c;
        }
    }
}
