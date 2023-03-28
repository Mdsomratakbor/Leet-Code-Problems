using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class CountTheNumberConsistentStrings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;
            for(int i=0; i<words.Length; i++)
            {
                bool isOkay = false;
                for (int k = 0; k < words[i].Length; k++)
                {
                    for (int j=0; j<allowed.Length; j++)
                {
                   
                        if (allowed[j] != words[i][k])
                        {
                            isOkay = true;
                            break;
                        }
                    }
                    if (isOkay)
                        break;
                }
                if(!isOkay)
                    count ++;
            }
            return count;
        }
    }
}
