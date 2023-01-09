using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class AppendCharactersToStringToMakeSubsequence
    {
        public int AppendCharacters(string s, string t)
        {
     
            int m = s.Length;
            int n = t.Length;
            int i = 0, j = 0;
            while (i < m && j < n)
            {
                if (s[i] == t[j])
                {
                    j++;
                }
                i++;
            }
            return n - j;
            //for (int i = 0; i <= t.Length; i++)
            //{
            //    string prefix = t.Substring(0, i);
            //    if (!s.Contains(prefix))
            //        count++;

            //}
            //return count;
        }
    }
}
