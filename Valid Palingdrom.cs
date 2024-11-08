using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Valid_Palingdrom
    {
        public bool IsPalindrome(string s)
        {
            var result = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result.Append(c);
                }
            }
            s = result.ToString().ToLower();

            int right = s.Length - 1, left = 0;
            while (left < right)
            {
                if (s[right] != s[left])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
