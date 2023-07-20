using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Minimize_String_Length
    {
        public int MinimizedStringLength(string s)
        {
            string ans = "";
            int i, j;
            for ( i=0; i<s.Length; i++)
            {
                for( j=0; j<i; j++)
                {
                    if (s[i] == s[j])
                    {
                        break;
                    }
                }
                if (j == i)
                {
                    ans += s[i];
                }
            }
            return ans.Length;
        }
    }
}
