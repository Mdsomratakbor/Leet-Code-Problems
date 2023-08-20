using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    internal class Sort_Vowels_in_a_String
    {
        public string SortVowels(string s)
        {
            List<KeyValuePair<int, char>> keyValuePairsOfVowelsAndIndex = new();
            int length = s.Length;
            for(int i = 0; i<length; i++)
            {
                if (IsVowel(s[i]))
                {
                    keyValuePairsOfVowelsAndIndex.Add(new KeyValuePair<int, char>( i, s[i]));
                }
            }

            if (keyValuePairsOfVowelsAndIndex.Count() == 0)
                return s;

            for (int i = 0; i < keyValuePairsOfVowelsAndIndex.Count - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < keyValuePairsOfVowelsAndIndex.Count - i - 1; j++)
                {
                    if (keyValuePairsOfVowelsAndIndex[j].Key < keyValuePairsOfVowelsAndIndex[j + 1].Key)
                    {
                        KeyValuePair<int, char> tempKey = keyValuePairsOfVowelsAndIndex[j];
                        keyValuePairsOfVowelsAndIndex[j] = new KeyValuePair<int, char>(keyValuePairsOfVowelsAndIndex[j].Key, keyValuePairsOfVowelsAndIndex[j + 1].Value);
                        keyValuePairsOfVowelsAndIndex[j + 1] = new KeyValuePair<int, char>(tempKey.Key, tempKey.Value);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
            StringBuilder sb = new StringBuilder(s);

            foreach (var pair in keyValuePairsOfVowelsAndIndex)
            {
                sb[pair.Key] = pair.Value;
            }

            return sb.ToString();
        }
        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                   c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
}
