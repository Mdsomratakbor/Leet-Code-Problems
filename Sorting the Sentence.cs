using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Sorting_the_Sentence
    {
        public string SortSentence(string s)
        {
            string[] orginalSentence = s.Split(' ');
            List<Tuple<string, int , bool>> keyValuePairs = new List<Tuple<string, int , bool>>();
            foreach (var word in orginalSentence)
            {

            }
            string temp = "";
            int left = 0, right = orginalSentence.Length;
            while (left<right)
            {
                int index = Int32.Parse(orginalSentence[left][orginalSentence[left].Length-1].ToString());
                temp = orginalSentence[index-1];
                orginalSentence[index-1] = orginalSentence[left];
                orginalSentence[left] = temp;
                left++;
            }

            string result = "";
            foreach (string word in  orginalSentence)
            {
                result += word.Substring(0, word.Length-1) + " ";
            }

            return result.TrimEnd();

        }
    }
}
