using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Merge_Strings_Alternately
    {
        public string MergeAlternately(string word1, string word2)
        {

            int left = 0, rightWord1 = word1.Length, rightWord2 = word2.Length;

            int right = Math.Max(rightWord1, rightWord2);

            StringBuilder result = new StringBuilder();
            while (left < right)
            {
                if(left<rightWord1)
                {
                    result.Append(word1[left]);
                }
                if (left < rightWord2)
                {
                    result.Append(word2[left]);
                }
                left++;
            }
            return result.ToString();   
        }

        public string MergeAlternately_2(string word1, string word2)
        {

            int left = 0, rightWord1 = word1.Length, rightWord2 = word2.Length;

            StringBuilder result = new StringBuilder();
            while (left < rightWord1 || left < rightWord2)
            {
                if (left < rightWord1)
                {
                    result.Append(word1[left]);
                }
                if (left < rightWord2)
                {
                    result.Append(word2[left]);
                }
                left++;
            }
            return result.ToString();
        }
    }
}
