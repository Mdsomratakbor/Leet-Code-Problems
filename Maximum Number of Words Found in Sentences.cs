using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Maximum_Number_of_Words_Found_in_Sentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int maximumCount = 0;
            foreach (string sentence in sentences)
            {
                string[] setenceWord = sentence.Split(' ');
                int length =  setenceWord.Count();
                if (length > maximumCount)
                {
                    maximumCount = length;
                }
            }
            return maximumCount;
        }
    }
}
