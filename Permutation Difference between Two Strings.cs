using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Permutation_Difference_between_Two_Strings
    {
        public int FindPermutationDifference(string s, string t)
        {
            int sum = 0;


            Dictionary<char, int> tMap = new Dictionary<char, int>();
            for (int k = 0; k < t.Length; k++)
            {
                tMap[t[k]] = k;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (tMap.TryGetValue(s[i], out int tIndex))
                {
                    sum += Math.Abs(i - tIndex);
                }
            }

            return sum;
        }
    }
}
