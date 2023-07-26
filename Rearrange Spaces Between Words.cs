using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Rearrange_Spaces_Between_Words
    {
        public string ReorderSpaces(string text)
        {
            int countSpace = 0;
            int wordCount = 0;
            bool in_word = false;
            string word = "";
            List<string> words = new List<string>();
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    countSpace++;
                    if (in_word)
                    {
                        wordCount++;
                        if (word.Length > 0)
                        {
                            words.Add(word);
                            word = string.Empty;
                        }
                        in_word = false;
                    }
                }
                else
                {
                    word += c;
                    in_word = true;
                }
            }
            if (word.Length > 0)
            {
                wordCount++;
                words.Add(word);
            }
            int totalSpace =  wordCount>1?  countSpace / (wordCount - 1): 0;

            string result = string.Empty;

            int remainingSpace = wordCount > 1 ? countSpace % (wordCount - 1) : countSpace;

            result = string.Join(new string(' ', totalSpace), words);
            if (remainingSpace > 0)
            {
                result += new string(' ', remainingSpace);
            }

            return result;

        }
    }
}
