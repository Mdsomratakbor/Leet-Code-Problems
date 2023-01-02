using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int length = nums.Length;
            int maxValue = 0;
            int i = 0;
            while(i< length && i<=maxValue)
            {
                maxValue= Math.Max(nums[i]+i, maxValue);

                i++;
            }
            if (i == length)
                return true;
            return false;
        }
    }
}
