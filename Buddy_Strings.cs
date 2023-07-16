using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Buddy_Strings
    {
        public bool BuddyStrings(string s, string goal)
        {
            string newString = "";
            if (string.IsNullOrEmpty(goal))
            {
                return false;
            }
            if (goal.Length < s.Length)
            {
                return false;
            }
            for(int i=0; i<s.Length; i++)
            {

            }
            return false;
        }
    }
}
