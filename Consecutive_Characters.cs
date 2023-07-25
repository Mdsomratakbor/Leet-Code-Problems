using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Consecutive_Characters
    {
        public int MaxPower(string s)
        {
            int tempCount = 1;
            int count = 1;
            char tempCharacter = ' ';
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == tempCharacter)
                {
                    tempCount++;
                    if (tempCount > count)
                    {
                        count = tempCount;
                    }
                }
                else
                {
                    tempCharacter = s[i];
                    tempCount = 1;                             
                }
            }
            return count;
        }
    }
}
