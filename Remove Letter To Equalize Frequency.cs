using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Remove_Letter_To_Equalize_Frequency
    {
        public bool EqualFrequency(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
               if(IsEqual(word, i))
                    return true;
            }
            return false;
        }
        private bool IsEqual(string word, int index) {

            word = word.Remove(index, 1);
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (keyValuePairs.ContainsKey(word[i]))
                    keyValuePairs[word[i]]++;
                
                else
                    keyValuePairs.Add(word[i], 1);
            }
            for(int i = 1; i<word.Length; i++)
            {
                if (keyValuePairs[word[i]] != keyValuePairs[word[i-1]])
                    return false;
            }
            
            return true;
        }
            //public bool EqualFrequency(string word)
            //{
            //    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        if (keyValuePairs.ContainsKey(word[i]))
            //        {
            //            keyValuePairs[word[i]]++;
            //        }
            //        else
            //        {
            //            keyValuePairs.Add(word[i], 1);
            //        }
            //    }

            //int count = keyValuePairs.Count(x => x.Value > 1);
            //if(count == 0)
            //    return true;
            //bool frequenciesEqual = true;
            //foreach (char c in keyValuePairs.Keys)
            //{
            //    int currentCount = keyValuePairs[c];
            //    keyValuePairs[c]--;

            //    foreach (var kvp in keyValuePairs)
            //    {
            //        if (kvp.Value != keyValuePairs[c] && kvp.Value != currentCount - 1)
            //        {
            //            frequenciesEqual = false;
            //            break;
            //        }
            //        else
            //        {
            //            frequenciesEqual = true;
            //        }
            //    }
            //    keyValuePairs[c]++;

            //    if (frequenciesEqual)
            //        return true;
            //}
            //return frequenciesEqual;
        }

    
}
