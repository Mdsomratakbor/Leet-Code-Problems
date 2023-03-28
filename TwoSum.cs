using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class TwoSum
    {
        public int[] TwoSumSolution(int[] nums, int target)
        {
            int[] arrayOfIndex = new int[2];
            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if(nums[i]+nums[j]== target)
                    {
                        arrayOfIndex[0] = i;
                        arrayOfIndex[1] = j;
                    }
                }
            }
            return arrayOfIndex;
        }
    }
}
