using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Find_the_Difference
    {
        public char FindTheDifference(string s, string t)
        {
            foreach (char c in s)
            {
                t = t.Remove(t.IndexOf(c), 1);
            }
            return t[0];
        }
    }
}
