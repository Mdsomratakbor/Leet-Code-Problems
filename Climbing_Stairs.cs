using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            int one = 1, two = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int temp = one;
                one += two;
                two = temp;
            }
            return one;
        }
    }
}
