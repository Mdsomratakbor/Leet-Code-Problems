using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class RemoveOutermostParentheses
    {
        public string RemoveOuterParentheses(string s)
    {
        StringBuilder result = new StringBuilder();
        int count = 0;
        foreach (char c in s)
        {
            if (c == '(' && count++ > 0)
                result.Append(c);
            if (c == ')' && count-- > 1)
                result.Append(c);
        }
        return result.ToString();
    }
    }
}