using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class CountPairsOfSimilarStrings
    {
        public int SimilarPairs(string[] words)
        {
            int count = 0;
            for(int i=0;i<words.Length; i++)
            {
                for(int j=i;j<words.Length; j++)
                {
                    if (words[i].OrderBy(x=>x).ToString() == words[j].OrderBy(x=>x).ToString())
                    {
                        count++;
                        break;
                    }
                        

                }
            }
            return count;
        }
    }
}
