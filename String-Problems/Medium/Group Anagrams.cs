using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.String_Problems.Medium
{
    internal class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
          
            foreach(var word in strs)
            {
                var sorted = string.Concat(word.OrderBy(c => c));
                if (!map.ContainsKey(sorted))
                {
                    map[sorted] = new List<string>();
                }
                map[sorted].Add(word);
            }
            return map.Values.ToList<IList<string>>();
        }
        public IList<IList<string>> GroupAnagramsTakingMoreTime(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();

            List<KeyValuePair<string, bool>> map = new List<KeyValuePair<string, bool>>();
            foreach (var word in strs)
            {
                map.Add(new KeyValuePair<string, bool>(word, false));
            }


            for (int i = 0; i < map.Count; i++)
            {
                if (map[i].Value)
                    continue;

                List<string> anagrams = new List<string>();
                string currentWord = map[i].Key;
                anagrams.Add(currentWord);

                // Set current word as used
                map[i] = new KeyValuePair<string, bool>(map[i].Key, true);

                for (int j = i + 1; j < map.Count; j++)
                {
                    if (map[j].Value)
                        continue;

                    string nextWord = map[j].Key;
                    if (nextWord.Length != currentWord.Length)
                        continue;

                    var currentWordSorted = String.Concat(currentWord.OrderBy(c => c));
                    var nextWordSorted = String.Concat(nextWord.OrderBy(c => c));

                    if (currentWordSorted == nextWordSorted)
                    {
                        anagrams.Add(nextWord);
                        map[j] = new KeyValuePair<string, bool>(map[j].Key, true); // Mark as used
                    }
                }

                if (anagrams.Count > 0)
                    list.Add(anagrams);
            }


            return list;
        }
    }
}
