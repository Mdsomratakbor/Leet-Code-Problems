using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class DecodeMessage
    {
        public static string DecodeMessageSolution(string key, string message)
        {
            string decodeMessage = "";

            Dictionary<char, char> dict = new Dictionary<char, char>()
        {
            {' ', ' '}
        };


            foreach (char c in key)
            {
                if (dict.ContainsKey(c)) continue;
                dict.Add(c, Convert.ToChar('a' + dict.Count() - 1));
            }

            foreach (char c in message)
            {
                decodeMessage += dict[c];
            }
            return decodeMessage;
        }

        public static int CountAsterisks(string s)
        {
            var replacedText = Regex.Replace(s, "(|[^|]+|)", "");
            return 0;
        }

        public static string GreatestLetter(string s)
        {

            Dictionary<char, bool> dict = new Dictionary<char, bool>();

            int size = s.Length;
            for (int i = 0; i < size; i++)
            {
                if (dict.ContainsKey(s[i])) continue;
                if (Char.IsUpper(s[i]))
                {
                    dict.Add(s[i], false);
                }



            }
            foreach (var data in dict)
            {
                foreach (var sm in s)
                {
                    if (char.ToLower(data.Key) == sm)
                    {
                        dict[data.Key] = true;
                    }

                }
            }
            var sortedDictionary = new SortedDictionary<char, bool>(dict);

            return sortedDictionary.LastOrDefault(x => x.Value == true).Key.ToString() == null ? "" : sortedDictionary.LastOrDefault(x => x.Value == true).Key.ToString();

        }
    }

}