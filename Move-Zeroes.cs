using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }
            while (current < nums.Length)
            {
                nums[current] = 0;
                current++;
            }
        }
    }
}
