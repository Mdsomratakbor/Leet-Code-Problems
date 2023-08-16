using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Most_Common_Word
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            string[] words = Regex.Split(paragraph, @"[\s\W]+");

            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var para in words)
            {
               string celanData = CleanString(para);
                if (celanData.Length > 0)
                {
                    if (!banned.Any(x => x == celanData))
                    {
                        if (dic.ContainsKey(celanData))
                            dic[celanData]++;
                        else
                            dic.Add(celanData, 1);
                    }
                }
               
            }
            KeyValuePair<string, int> max = new KeyValuePair<string, int>();
            foreach (var entry in dic)
            {
                if (entry.Value > max.Value)
                {
                    max = entry;
                }
            }
            return max.Key;

        }
        static string CleanString(string input)
        {
            // Remove special characters using regex
            string cleaned = Regex.Replace(input, @"[^a-zA-Z0-9]", "");

            // Convert to lowercase
            string lowercase = cleaned.ToLower();

            return lowercase;
        }
    }
}
