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
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for(int i=0; i<word.Length; i++)
            {
                if (keyValuePairs.ContainsKey(word[i]))
                {
                    keyValuePairs[word[i]]++;
                }
                else
                {
                    keyValuePairs.Add(word[i], 1);
                }
            }

            int maxFrequency = keyValuePairs.Values.Max();
            int minFrequency = keyValuePairs.Values.Min();

            // Check if all frequencies are equal
            if (maxFrequency == minFrequency)
                return true;

            return maxFrequency - minFrequency <= 1;

        }
    }
}
