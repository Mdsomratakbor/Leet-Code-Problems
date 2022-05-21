using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            int reminder=0, reversed = 0, orginal = x;
            if (x < 0)
                return false;
            while (x != 0)
            {
                reminder = x%10;
                reversed = (reversed * 10) + reminder;
                x /= 10;
            }
            if (orginal == reversed)
                return true;
            else
                return false;
        }
    }
}
