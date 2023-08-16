using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Replace_All_Digits_with_Characters
    {

        public string ReplaceDigits(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i+=2)
            {
                sb.Append(s[i]);
                if (1+i <s.Length)
                {
                    sb.Append(Convert.ToChar(Convert.ToInt32(s[i + 1]) + s[i] - '0'));
                }
               
            }
            return sb.ToString();
        }
        // Need to optimize the problem
        public string ReplaceDigits_Old(string s)
        {
            StringBuilder sb = new StringBuilder(); 
            for(int i=0; i<s.Length; i++)
            {
                if (char.IsDigit(s[i]) && i>0)
                {
                    sb.Append(Convert.ToChar(Convert.ToInt32(s[i-1]) + s[i] - '0'));
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
    }
}
