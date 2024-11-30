using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> firstRow = new HashSet<char>("qwertyuiop");
            HashSet<char> secondRow = new HashSet<char>("asdfghjkl");
            HashSet<char> thirdRow = new HashSet<char>("zxcvbnm");
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                HashSet<char> targetWord = new HashSet<char>();
                if (firstRow.Contains(lowerWord[0]))
                    targetWord = firstRow;
                else if (secondRow.Contains(lowerWord[0]))
                    targetWord = secondRow;
                else if (thirdRow.Contains(lowerWord[0]))
                    targetWord = thirdRow;

                if (lowerWord.All(x=>targetWord.Contains(x)))
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }
        public string[] FindWords_Complex_Way(string[] words)
        {
            string firstRow = "qwertyuiop";
            string secondRow = "asdfghjkl";
            string thirdRow = "zxcvbnm";


            List<string> result = new List<string>();
            foreach (string word in words)
            {
                int firstrowcount = 0, secondRowCount = 0, thirdRowCount = 0;
                int length = word.Length;
                string lowerWord = word.ToLower();
                foreach (char character in lowerWord)
                {
                    if (!firstRow.Contains(character))
                    {
                        break;
                    }
                    else
                    {
                        firstrowcount += 1;
                    }
                }
                if (firstrowcount == 0)
                {
                    foreach (char character in lowerWord)
                    {
                        if (!secondRow.Contains(character))
                        {
                            break;
                        }
                        else
                        {
                            secondRowCount += 1;
                        }
                    }
                }
                if (secondRowCount == 0)
                {
                    foreach (char character in lowerWord)
                    {
                        if (!thirdRow.Contains(character))
                        {
                            break;
                        }
                        else
                        {
                            thirdRowCount += 1;
                        }
                    }
                }
                if (firstrowcount == length || secondRowCount == length || thirdRowCount == length)
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }



    }
}
