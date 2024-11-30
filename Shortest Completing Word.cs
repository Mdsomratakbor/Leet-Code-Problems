using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Shortest_Completing_Word
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char c in licensePlate)
            {
                if (char.IsLetter(c))
                {
                    char lowerCharacter = char.ToLower(c);
                    if (keyValuePairs.ContainsKey(lowerCharacter))
                    {
                        keyValuePairs[lowerCharacter] = keyValuePairs[lowerCharacter] + 1;
                    }
                    else
                    {
                        keyValuePairs.Add(lowerCharacter, 1);
                    }
                }
            }
            string shortestWord = null;
            foreach (string word in words)
            {
                bool isCompletingWord = true;
                foreach(var kvp in keyValuePairs)
                {
                    if (word.Count(x => x == kvp.Key) < kvp.Value)
                    {
                        isCompletingWord = false;
                        break;
                    }
                }
                if (isCompletingWord && (shortestWord == null || word.Length < shortestWord.Length))
                {
                    shortestWord = word;
                }

            }

            return shortestWord;
        }
    }
}
