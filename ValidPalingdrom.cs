using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeProblems
{
    public class ValidPalingdrom
    {
        public bool IsPalindrome(string s)
        {
          
            s = Regex.Replace(s, @"(\s+|\.|,|-|_|:|@|&|'|\(|\)|[^-/\w\s]|<|>|#)", "");
            s = s.Replace(" ", string.Empty).ToLower();
            int right = 0, left = s.Length - 1;
            while (right < left)
            {
                if (s[right] != s[left])
                    return false;
                
                right++;
                left--;
            }
            return true;
        }
    }
}
