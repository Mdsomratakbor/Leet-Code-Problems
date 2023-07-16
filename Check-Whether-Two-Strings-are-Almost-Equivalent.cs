using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_Whether_Two_Strings_are_Almost_Equivalent
    {
        public bool CheckAlmostEquivalent(string word1, string word2)
        {

            string duplicatesRemoved = string.Join(" ", word1.Split(' ').Distinct());
             duplicatesRemoved += string.Join(" ", word2.Split(' ').Distinct());
            for (int i=0; i< duplicatesRemoved.Length; i++)
            {
                int count1 = 0;
                int count2 = 0;
                for (int j=0; j<word1.Length; j++)
                {
                    if (duplicatesRemoved[i] == word1[j])
                        count1++;
                }

                for(int j = 0; j < word2.Length; j++) 
                {
                    if (duplicatesRemoved[i] == word2[j])
                        count2++; 

                }
                if (Math.Abs(count1-count2)>=4)
                    return false;
            }
            return true;
        }

      
    }
}
