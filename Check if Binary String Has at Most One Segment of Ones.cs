using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_if_Binary_String_Has_at_Most_One_Segment_of_Ones
    {
        public bool CheckOnesSegment(string s)
        {
            bool isFoundZero = false;

            foreach (char c in s)
            {
                if (c == '0')
                    isFoundZero = true;

                if (isFoundZero && c == '1')
                    return false;
            }
            return true;
        }
    }
}
