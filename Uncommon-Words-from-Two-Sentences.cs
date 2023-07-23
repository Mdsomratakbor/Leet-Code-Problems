using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Uncommon_Words_from_Two_Sentences
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            List<string> result = new List<string>();
            var stringArray1 = s1.Split(" ");
            var stringArray2 = s2.Split(" ");
            Dictionary<string, int> map  = new Dictionary<string, int>();
             foreach (string word  in stringArray1)
            {
                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else {
                    map[word] = 1;
                }
            }
            foreach (var word in stringArray2)
            {
                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else
                {
                    map[word] = 1;
                }
            }

            foreach(var data in map)
            {
                if (data.Value == 1)
                {
                    result.Add(data.Key);
                }
            }
            return result.ToArray();

        }
    }
}
