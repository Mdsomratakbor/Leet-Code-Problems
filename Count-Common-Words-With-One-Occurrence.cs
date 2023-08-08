using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_Common_Words_With_One_Occurrence
    {
        public int CountWords(string[] words1, string[] words2)
        {
            Dictionary<string, int> words1List = new Dictionary<string, int>();
            Dictionary<string, int> words2List = new Dictionary<string, int>();
            int count = 0;
            foreach(string word in words1)
            {
                if (words1List.ContainsKey(word))
                {
                    words1List[word]++;
                }
                else
                {
                    words1List[word] = 1;
                }
            }
            foreach (string word in words2)
            {
                if (words2List.ContainsKey(word))
                {
                    words2List[word]++;
                }
                else
                {
                    words2List[word] = 1;
                }
            }
            foreach(string key in words1List.Keys)
            {
                int count1 = words1List.ContainsKey(key) ? words1List[key] : 0;
                int count2 = words2List.ContainsKey(key) ? words2List[key] : 0;
                if(count1 ==1 && count2 == 1)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
