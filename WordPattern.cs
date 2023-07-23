using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class WordPatternCheck
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] patternData = s.Split(' ');

            int patternDataLength = patternData.Length;
            if (patternDataLength != pattern.Length)
                return false;

            Dictionary<char, string> list = new Dictionary<char, string>();
            for (int i = 0; i < patternDataLength; i++)
            {

                if (list.ContainsKey(pattern[i]) && list[pattern[i]].Equals(patternData[i]))
                {
                    continue;
                }
                else if (!list.ContainsKey(pattern[i]) && !list.ContainsValue(patternData[i]))
                {
                    list.Add(pattern[i], patternData[i]);
                }
                else
                {
                    return false;
                }
             

            }
            return true;
        }
    }
}
