using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_if_All_A_s_Appears_Before_All_B_s
    {
        public bool CheckString(string s)
        {
            bool isFoundB = false;
            foreach (char c in s)
            {
                char lowerChar = Char.ToLower(c);

                if (lowerChar == 'b')
                {
                    isFoundB = true;
                }
                else if (isFoundB && lowerChar == 'a')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
