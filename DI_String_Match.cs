using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class DI_String_Match
    {
        public int[] DiStringMatch(string s)
        {
            int left = 0, right = s.Length;
            int[] outputArray = new int[right+1];
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == 'I')
                {
                    outputArray[i] = left;
                    left++;
                }
                else if (s[i] == 'D')
                {
                    outputArray[i] = right;
                    right--;
                }
                
                i++;

            }
            outputArray[i] = left;
            return outputArray;
        }
    }
}
