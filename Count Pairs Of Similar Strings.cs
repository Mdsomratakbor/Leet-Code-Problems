using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_Pairs_Of_Similar_Strings
    {

        public int SimilarPairs(string[] words)
        {
            Dictionary<string, int> uniqueWordCount = new Dictionary<string, int>();
            int count = 0;

            foreach(var word in words)
            {
                string uniqueCharKey = GetUniqueCharacterKey(word);

                if (uniqueWordCount.ContainsKey(uniqueCharKey))
                {
                    count += uniqueWordCount[uniqueCharKey];
                    uniqueWordCount[uniqueCharKey]++;
                }
                else
                {
                    uniqueWordCount[uniqueCharKey] = 1;
                }
            }
            return count;
        }

        static string GetUniqueCharacterKey(string word)
        {
            HashSet<char> charSet = new HashSet<char>(word);
            char[] sortedChars = new char[charSet.Count];
            charSet.CopyTo(sortedChars);
            Array.Sort(sortedChars);
            return new string(sortedChars);
        }
        /// <summary>
        /// 👉 Final Complexity: O(n² + n* m) ≈ O(n²) for large n. 🚀
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int SimilarPairs_Old(string[] words)
        {
            string[] uniqueCharacterWord = new string[words.Length];
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                uniqueCharacterWord[i] = RemoveDuplicateCharacters(word);

            }
            for (int i = 0; i < uniqueCharacterWord.Length; i++)
            {
                for (int j = i + 1; j < uniqueCharacterWord.Length; j++)
                {
                    if (HaveSameUniqueCharacters(uniqueCharacterWord[i], uniqueCharacterWord[j]))
                        count++;
                }
            }



            return count;
        }
        static bool HaveSameUniqueCharacters(string word1, string word2)
        {
            bool[] chars1 = new bool[26];
            bool[] chars2 = new bool[26];

            foreach (char c in word1)
                chars1[c - 'a'] = true;

            foreach (char c in word2)
                chars2[c - 'a'] = true;
            for (int i = 0; i < 26; i++)
            {
                if (chars1[i] != chars2[i])
                    return false;
            }

            return true;
        }
        static string RemoveDuplicateCharacters(string word)
        {
            bool[] seen = new bool[26];
            StringBuilder sb = new StringBuilder();

            foreach (char c in word)
            {
                if (!seen[c - 'a'])
                {
                    sb.Append(c);
                    seen[c - 'a'] = true;
                }
            }

            return sb.ToString();
        }
    }
}
