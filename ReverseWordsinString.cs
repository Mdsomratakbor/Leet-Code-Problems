using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ReverseWordsinString
    {
        public string ReverseWords(string s)
        {
            StringBuilder reverseString= new StringBuilder();
            var stringData = Regex.Split(s, @"\s+", RegexOptions.IgnorePatternWhitespace);
            for (int i= stringData.Length-1; i>=0; i--)
            {
                reverseString.Append(stringData[i]);
                reverseString.Append(" ");
            }
            return reverseString.ToString().Trim();
        }
    }
}
