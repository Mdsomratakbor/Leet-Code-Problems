using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Number_of_Different_Integers_in_a_String
    {
        public int NumDifferentIntegers(string word)
        {
            int count = 0;

            for(int i=0; i<word.Length; i++)
            {
                if (char.IsDigit(word[i]) && word[i] != '0')
                {
                    for(int j=i; j<word.Length; j++)
                    {
                        if (!char.IsDigit(word[j]))
                        {
                            count++;
                            i = j;
                            break;
                        }
                    }
                
                }
            }
            return count;

        }
    }
}
