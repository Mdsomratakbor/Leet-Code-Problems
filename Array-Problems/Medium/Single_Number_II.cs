using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_Problems.Medium
{
    public class Single_Number_II
    {
        /// <summary>
        /// using this approace beat only 18.9%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberFirstApproach(int[] nums)
        {
            HashSet<int> hasSet = new HashSet<int>();
            HashSet<int> hasSetOfShadows = new HashSet<int>();
            foreach(int num in nums)
            {
                if (hasSet.Contains(num) || hasSetOfShadows.Contains(num))
                {
                    
                    hasSet.Remove(num);
                    hasSetOfShadows.Add(num);

                }
                else
                {
                    hasSet.Add(num);
                }
            }
            return hasSet.FirstOrDefault();
        }

        /// <summary>
        /// runtime  74ms and memory 42.4 MB 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);

            for(int i=1; i<nums.Length; i+=3)
            {
                if (nums[i - 1] != nums[i] || nums[i] != nums[i + 1])
                    return nums[i-1];
            }
            return nums[nums.Length - 1];
        }
    }
}
