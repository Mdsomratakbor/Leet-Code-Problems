using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_if_Number_Has_Equal_Digit_Count_and_Digit_Value
    {
        public bool DigitCount_Old(string num)
        {

            for (int i = 0; i < num.Length; i++)
            {
                int value = num[i] - '0';
                int count = num.Count(c => c - '0' == i );
                if (count != value)
                {
                    return false;

                }


            }
            return true;
        }

        public bool DigitCount(string num)
        {
            int[] digitCount = new int[10];
            foreach (char c in num)
            {
                digitCount[c - '0']++;
            }
            for (int i = 0; i < num.Length; i++)
            {
                int value = num[i] - '0';
                if (digitCount[i] != value)
                {
                    return false;
                }


            }
            return true;
        }
    }
}
