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

            List<KeyValuePair<char, string>> list = new List<KeyValuePair<char, string>>();
            for (int i = 0; i < patternDataLength; i++)
            {

                list.Add(new KeyValuePair<char, string>(pattern[i], patternData[i]));

            }
            int index = 0;
            foreach (KeyValuePair<char, string> pair in list)
            {
                if (pair.Key == pattern[index] && pair.Value == patternData[index])
                {
                    index++;
                    continue;
                
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
