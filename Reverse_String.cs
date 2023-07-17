using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reverse_String
    {
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length  -  1;
            char temp = ' ';
            while (left<right)
            {
                temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            
        }
    }
}
