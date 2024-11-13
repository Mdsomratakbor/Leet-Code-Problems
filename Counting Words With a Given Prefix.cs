using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Counting_Words_With_a_Given_Prefix
    {
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0; ;
            foreach (var word in words)
            {
                if (word.StartsWith(pref))
                    count++;
            }
            return count;
        }
    }
}
