using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MajorityElement
    {

        //Complexity O(n^2)
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


    // complexity O(n)
    //public class Solution
    //{
    //    public int MajorityElement(int[] nums)
    //    {
    //        if (nums == null || nums.Length == 0)
    //            return -1;

    //        var length = nums.Length;
    //        var majority = nums[0];
    //        var count = 1;
    //        var hasMajority = true;
    //        for (int i = 1; i < length; i++)
    //        {
    //            var current = nums[i];
    //            if (hasMajority)
    //            {
    //                if (current == majority)
    //                {
    //                    count++;
    //                }
    //                else
    //                {
    //                    count--;
    //                }

    //                hasMajority = count > 0;
    //            }
    //            else
    //            {
    //                count = 1;
    //                hasMajority = true;
    //                majority = nums[i];
    //            }
    //        }

    //        return majority;
    //    }
    //}
}
