using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Roman_to_Integer
    {

        private int RomanValue(char r)
        {
            switch (r)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return -1;
            }
        }

        public int RomanToInt(string s)
        {
            int result = 0;
            int length = s.Length;
            for(int i=0; i< length; i++)
            {
                int s1 = RomanValue(s[i]);
                if (i + 1 < length)
                {
                    int s2 = RomanValue(s[i + 1]);
                    if (s1 >= s2)
                        result += s1;
                    else
                        result = result - s1;
                }
                else
                {
                    result += s1;
                    i++;
                }
            }
            return result;
        }




    }
}
