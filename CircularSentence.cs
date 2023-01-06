using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class CircularSentence
    {
        public bool IsCircularSentence(string sentence)
        {
            var sentenceArray = sentence.Split(' ');
            int i = 0;
            int length = sentenceArray.Length;
            while (i < length-1)
            {
          
                if ((sentenceArray[i].LastOrDefault() != sentenceArray[i+1].FirstOrDefault()))
                {
                    return false;
                }
                i++;
            }
      
            return sentenceArray[0].FirstOrDefault() == sentenceArray[length - 1].LastOrDefault();
        }
    }
}
