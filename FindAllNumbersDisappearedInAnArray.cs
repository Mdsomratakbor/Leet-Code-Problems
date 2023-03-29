using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();
            Array.Sort(nums);
            int count = 1;
            for (int i =0; i<nums.Length; i++ )
            {
                if (nums[i]!= count)
                    result.Add(count);
                count++;
            }
            return result;
        }
    }
}
