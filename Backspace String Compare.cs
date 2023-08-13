using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Backspace_String_Compare
    {
        public bool BackspaceCompare(string s, string t)
        {
        
           if (FirstString(s) == LastString(t))
           return true ;

            return false;

        }

       private string FirstString(string s)
        {
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '#')
                {
                    
                    s = s.Remove(i, 1);
                    if (i > 0)
                    {
                        s = s.Remove(i - 1, 1);
                    }
                   
                    return FirstString(s);
                }
                   
            }
            return s;
        }
        private string LastString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    s = s.Remove(i, 1);
                    if (i > 0)
                    {
                        s = s.Remove(i - 1, 1);
                    }
                    return LastString(s);
                }

            }
            return s;
        }
    }
}
