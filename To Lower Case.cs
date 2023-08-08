using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class To_Lower_Case
    {
        public string ToLowerCase(string s)
        {
            char[] charArray = s.ToCharArray();
            for (int i=0; i< charArray.Length; i++)
            {
                if (s[i]>='A' && s[i] <= 'Z')
                {
                    charArray[i] = (char)(charArray[i] + 32);

                }
            }
            string result = new string(charArray);
            return result;
        }

    }
}
