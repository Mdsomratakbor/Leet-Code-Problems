using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Math_Problems.Easy
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {
            while (n>9)
            {
                int sum = 0;
                while (n>0)
                {
                    sum += (n % 10) * (n % 10);
                    n = n/ 10;
                }
                n = sum;
            }

            return n== 7 || n == 1;

        }
    }
}
