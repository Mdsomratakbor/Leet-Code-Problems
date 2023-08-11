using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_the_Number_of_Consistent_Strings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int count=0;

            foreach (string word in words)
            {
                bool isCount = true;
                for (int i = 0; i<allowed.Length; i++)
                {
                    for (int j = 0; j<word.Length; j++)
                    {
                        if (!allowed.Contains(word[j]))
                        {
                            isCount = false;
                            break;
                        }
                    }
                    if (!isCount)
                        break;
                }
                if (isCount)
                    count++;

            }
            
                return count;
        }
    }
}
