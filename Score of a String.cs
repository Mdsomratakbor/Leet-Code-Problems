using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Score_of_a_String
    {
        public int ScoreOfString(string s)
        {
            int sum = 0;
            for(int i=0; i<s.Length-1; i++)
            {
               
                    int sI = (int)s[i];
                    int sj = (int)s[i+1];
                    sum += Math.Abs(sI - sj);
                
            }
            return sum;
        }
    }
}
