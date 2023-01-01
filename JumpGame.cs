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
            bool output = false;
            int length = nums.Length;
            for(int i=0; i< length; i++)
            {
                if (length == 1)
                {
                    output = true;
                }
                
                if (nums[i]+i == length-1 || nums[i]+i>length-1)
                {
                    output = true; break;
                }

            }
            return output;
        }
    }
}
