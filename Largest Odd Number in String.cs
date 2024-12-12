using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Largest_Odd_Number_in_String
    {
        public string LargestOddNumber(string num)
        {
            int left = 0, right = num.Length-1;
            while (right >= left)
            {
                if ((num[right] - '0') % 2 != 0)
                {
                    return num.Substring(left, right + 1);
                }
                right--;
            }
            return "";
        }
    }
}
