using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_Balanced_String
    {
        public bool IsBalanced(string num)
        {

            int oddSum = 0, evenSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int number = num[i] - '0';
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            return oddSum == evenSum;
        }
    }
}
