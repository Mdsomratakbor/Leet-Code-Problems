using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Check_If_Two_String_Arrays_are_Equivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            foreach (string word in word1)
            {
                sb.Append(word);
            }
            foreach (string wor2 in word2)
            {
                sb2.Append(wor2);
            }
            return sb.ToString().Equals(sb2.ToString());
        }
    }
}
