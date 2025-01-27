using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Count_Prefixes_of_a_Given_String
    {
        public int CountPrefixes(string[] words, string s)
        {
            int count = 0;

            foreach (string word in words)
            {
                if (word.Length > s.Length)
                    continue;
                if (s.StartsWith(word))
                {
                    count++;
                }

            }
            return count;
        }
    }
}
