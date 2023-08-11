using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Shuffle_String
    {
        // Beat 92%
        public string RestoreString(string s, int[] indices)
        {
            char[] chars = s.ToCharArray();
            int length = s.Length;

            bool swapped = false;
            var temp = 0;
            var tempChar = ' ';
            for (int i = 0; i<length; i++)
            {
                swapped = false;
                for (int j = 0; j<length - i -1; j++)
                {
                    if (indices[j]>indices[j+1])
                    {
                        temp = indices[j];
                        tempChar = chars[j];
                        indices[j] = indices[j+1];
                        chars[j] = chars[j+1];
                        indices[j + 1] = temp;
                        chars[j + 1] = tempChar;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            string result = new string(chars);

            return result;
        }

        // Beat 48%

        public string RestoreString_OLD(string s, int[] indices)
        {
            List<KeyValuePair<char, int>> keyValuePairs = new List<KeyValuePair<char, int>>();
            for (int i = 0; i<s.Length; i++)
            {
                keyValuePairs.Add(new KeyValuePair<char, int>(s[i], indices[i]));
            }
            int length = s.Length;

            bool swapped = false;
            var temp = new KeyValuePair<char, int>();
            for (int i = 0; i<length; i++)
            {
                swapped = false;
                for (int j = 0; j<length - i -1; j++)
                {
                    if (keyValuePairs[j].Value>keyValuePairs[j+1].Value)
                    {
                        temp = keyValuePairs[j];
                        keyValuePairs[j] = keyValuePairs[j+1];
                        keyValuePairs[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            StringBuilder result = new StringBuilder();
            foreach (var kp in keyValuePairs)
            {
                result.Append(kp.Key);
            }

            return result.ToString();
        }
    }
}
