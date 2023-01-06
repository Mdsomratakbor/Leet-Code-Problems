using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ReplaceWord
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var sentenceArray = sentence.Split(' ');
            for (int i = 0; i<sentenceArray.Length; i++)
            {
               
                    for(int j=0; j<sentenceArray[i].Length; j++)
                    {
                        string prefix = sentenceArray[i].Substring(0, j);
                    foreach (var word in dictionary)
                    {
                        if (word ==prefix)
                        {
                           sentenceArray[i] = prefix;
                            break;

                        }
                    }
                   
                }
            }
            return String.Join(" ", sentenceArray);
        }
    }
}
