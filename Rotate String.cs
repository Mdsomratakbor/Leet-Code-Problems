using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Rotate_String
    {
        public bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length) return false;

            for (int i = 0; i < s.Length; i++)
            {
                s = s.Substring(1) + s[0];
                if (s == goal)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
