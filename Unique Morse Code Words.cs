using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Unique_Morse_Code_Words
    {
        public int UniqueMorseRepresentations(string[] words)
        {

            string[] morseCodes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<char, string> mapped = new Dictionary<char, string>();

            for (int i = 0; i < morseCodes.Length; i++)
            {
                mapped.Add((char)('a' + i), morseCodes[i]);
            }

            HashSet<string> result = new HashSet<string> ();

            foreach (string word in words)
            {
                string morseWord = "";
                foreach (char c in word)
                {
                   var data = mapped[c];

                    morseWord += data;

                }
                result.Add (morseWord);
            }
            return result.Count;

        }
    }
}
