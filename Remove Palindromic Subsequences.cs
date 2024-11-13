using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Remove_Palindromic_Subsequences
    {
        public int RemovePalindromeSub(string s)
        {
            if (IsPalindrom(s))
                return 1;

            return 2;
        }

        private bool IsPalindrom(string s)
        {
            int left = 0, right = s.Length - 1;
            string result = s;
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;



        }
    }
}
