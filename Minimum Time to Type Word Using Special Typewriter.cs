using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Minimum_Time_to_Type_Word_Using_Special_Typewriter
    {
        public int MinTimeToType(string word)
        {
            int time = 0;
            char current = 'a';  

            foreach (char c in word)
            {
                int distance = Math.Abs(c - current);
                int minValue = Math.Min(distance, 26 - distance);
                time += minValue + 1;
                current = c;
            }
            return time;
        }
    }
}
