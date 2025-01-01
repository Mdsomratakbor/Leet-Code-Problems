using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Longest_Palindrome
    {

        public class Solution
        {
            public int LongestPalindrome(string s)
            {
                Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
                if (string.IsNullOrEmpty(s))
                    return 0;
                var charCount = new Dictionary<char, int>();
                foreach (var c in s)
                {
                    if (charCount.ContainsKey(c))
                        charCount[c]++;
                    else
                        charCount[c] = 1;
                }
                int length = 0;
                bool hasOneOdd = false;

                foreach (int count in charCount.Values)
                {

                    length += count / 2 * 2;
                    if (count % 2 == 1)
                        hasOneOdd = true;
                }
                if (hasOneOdd)
                    length++;
                return length;
            }
        }

        //public int LongestPalindrome(string s)
        //{
        //    if (string.IsNullOrEmpty(s) || s.Length < 1)
        //        return 0;


        //    int start = 0, end = 0, maxLength =0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        int oddLength = ExpandAroundCenter(s, i, i);
        //        int evenLength = ExpandAroundCenter(s, i, i + 1);
        //        maxLength = Math.Max(oddLength, evenLength);



        //        if (maxLength > (end - start))
        //        {
        //            start = i - (maxLength - 1) / 2;
        //            end = i + maxLength / 2;
        //        }
        //    }
        //    return maxLength;
        //}

        //private int ExpandAroundCenter(string s, int left, int right)
        //{
        //    while (left >= 0 && right < s.Length && s[left] == s[right])
        //    {
        //        left--;
        //        right++;
        //    }

        //    return right - left - 1;
        //}



    }
}
