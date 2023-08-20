using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Math_Problems.Easy
{
    internal class Perfect_Number
    {
        /// <summary>
        /// Beats 48.04%of users with C#
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>

        public bool CheckPerfectNumber(int num)
        {
            int i = 1, sum = 0;
            for (i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
        /// <summary>
        /// Beats 25.14%of users with C#
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CheckPerfectNumber_25_Percentage(int num)
        {
            int i = 1, sum = 0;
            for(i =1; i<num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
    }
}
