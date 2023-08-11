using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Shuffle_String
    {
        public string RestoreString(string s, int[] indices)
        {
            List<KeyValuePair<char, int>> keyValuePairs = new List<KeyValuePair<char, int>>();
            for(int i=0; i<s.Length; i++)
            {
                keyValuePairs.Add(new KeyValuePair<char, int>(s[i], indices[i]));
            }
            int length = s.Length;
            
            bool swapped = false;
            var temp = new KeyValuePair<char, int>();
            for(int i=0; i<length; i++)
            {
                swapped = false;
                for(int j=0; j<length - i -1; j++)
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
