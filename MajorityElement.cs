using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MajorityElement
    {
        public int MajorityElementSolution(int[] nums)
        {
            int count = 0, maxCount = 0, index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }

            }
            return nums[index];

        }
    }
}
