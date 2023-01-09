using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class FirstUniqueCharacterString
    {
        public int FirstUniqChar(string s)
        {
            for(int i=0; i<s.Length; i++)
            {
               // bool found = true;
                //for (int j=0; j<s.Length; j++)
                //{
                    if (s.IndexOf(s[i], s.IndexOf(s[i]) + 1)
                == -1)
                    {
                       //found = false;
                       return i;
                    }
                  
               // }
              //  if (found) return i;
            }
            return -1;
        }
    }
}
