using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Decrypt_String_from_Alphabet_to_Integer_Mapping
    {
        public string FreqAlphabets(string s)
        {
            var mapping = new Dictionary<string, char> {
            { "1", 'a' }, { "2", 'b' }, { "3", 'c' }, { "4", 'd' },
            { "5", 'e' }, { "6", 'f' }, { "7", 'g' }, { "8", 'h' },
            { "9", 'i' }, { "10#", 'j' }, { "11#", 'k' }, { "12#", 'l' },
            { "13#", 'm' }, { "14#", 'n' }, { "15#", 'o' }, { "16#", 'p' },
            { "17#", 'q' }, { "18#", 'r' }, { "19#", 's' }, { "20#", 't' },
            { "21#", 'u' }, { "22#", 'v' }, { "23#", 'w' }, { "24#", 'x' },
            { "25#", 'y' }, { "26#", 'z' }
        };
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while(i < s.Length)
            {
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    string key = s.Substring(i, 3);
                    if (mapping.ContainsKey(key))
                    {
                        sb.Append(mapping[key]);
                        i += 3;
                    }
                }
                else
                {
                    string key = s.Substring(i, 1);
                    if (mapping.ContainsKey(key))
                    {
                        sb.Append(mapping[key]);
                        i++;
                    }
                }
            

            }
            return sb.ToString();
        }
    }
}
