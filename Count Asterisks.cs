using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Count_Asterisks
    {
        public int CountAsterisks(string s)
        {
            int totalAsterisks = 0;
            int barCount = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '|') barCount++;
                else 
                    if(barCount%2==0 && s[i]=='*')totalAsterisks++;
            }
            return totalAsterisks;
        }
    }
}
