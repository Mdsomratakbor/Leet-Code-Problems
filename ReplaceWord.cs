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
            var orderedDict = dictionary.OrderBy(s => s.Length);
            var sentenceArray = sentence.Split(' ');

            for (int i = 0; i < sentenceArray.Length; i++)
            {
              //  bool isReplace = false;
               // for (int j = 0; j < sentenceArray[i].Length; j++)
               // {
                    //sstring prefix = sentenceArray[i].Substring(0, j);
                    foreach (var word in orderedDict)
                    {
                        if (sentenceArray[i].StartsWith(word))
                        {
                            sentenceArray[i] = word;
                            isReplace = true;
                            break;

                        }
                    }
                  //  if (isReplace) break;

               // }
               
            }
            return String.Join(" ", sentenceArray);
        }
    }
}
