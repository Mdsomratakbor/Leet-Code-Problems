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
            char[] chars = s.ToCharArray();
            for(int i=0; i<chars.Length-1; i++)
            {
                if ((char.IsDigit(chars[i]) && char.IsLetter(chars[i+1])) || (char.IsDigit(chars[i+1]) && char.IsLetter(chars[i])))
                {
                    char temp = chars[i];
                    chars[i] =  chars[i+1];
                    chars[i+1] = temp;
                }
                else if((char.IsDigit(chars[i]) && char.IsDigit(chars[i+1])) || (char.IsLetter(chars[i+1]) && char.IsLetter(chars[i])))
                {
                    chars = null;
                    break;
                }
            }
            string result = new string(chars);
            return result;
        }
    }
}
