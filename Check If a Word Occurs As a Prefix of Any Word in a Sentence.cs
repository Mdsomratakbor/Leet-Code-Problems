using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] arrayOfString = sentence.Split(' ');
            int count = 1;
            foreach (string word in arrayOfString)
            {
                if (word.StartsWith(searchWord))
                {
                    return count;
                }
                count++;
            }
            return -1;
        }
    }
}
