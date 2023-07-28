using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Reformat_The_String
    {
      
        public string Reformat(string s)
        {

            StringBuilder result = new StringBuilder();
            int i = 0;
            while (i<s.Length-1)
            {
                if ((char.IsDigit(s[i]) && char.IsLetter(s[i+1])) || (char.IsDigit(s[i+1]) && char.IsLetter(s[i])))
                {
                    char temp = s[i];
                    result.Append(s[i+1]);
                    result.Append(temp);
                    i+=2;
                }
                else
                {
                    i++;
                }
                //else if((char.IsDigit(chars[i]) && char.IsDigit(chars[i+1])) || (char.IsLetter(chars[i+1]) && char.IsLetter(chars[i])))
                //{
                //    chars = null;
                //    break;
                //}
            }
            // string result = new string(result);
            return result.ToString();
        }
    }
}
