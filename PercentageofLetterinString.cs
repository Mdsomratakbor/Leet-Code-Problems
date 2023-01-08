using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class PercentageofLetterinString
    {
        public int PercentageLetter(string s, char letter)
        {
            double length = s.Length;
            double count = 0;
            for(int i=0;i<length; i++)
            {
                if (s[i]==letter)
                    count++;
            }
            return (int) ((count / length) * 100);
        }
    }
}
