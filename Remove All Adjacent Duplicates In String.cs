using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Remove_All_Adjacent_Duplicates_In_String
    {
        public string RemoveDuplicates(string s)
        {
            if (s.Length < 2)
                return s;
            int i, j;
            for (i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    return RemoveDuplicates(s);
                }
             
                
            }
            return s;
        }
    }
}
