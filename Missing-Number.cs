using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Missing_Number
    {
        public int MissingNumber(int[] nums)
        {
            int lengthOfArray = nums.Length;
            Array.Sort(nums);
            int output = 0;
            for (int i = 0; i < lengthOfArray; i++)
            {
                if (nums[i] != i)
                {
                    return i;

                }

            }
            return lengthOfArray;

        }
    }
}
