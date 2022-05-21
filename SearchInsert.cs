using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
   public class SearchInsert
    {
        public int SearchInsertSolution(int[] nums, int target)
        {
            int output = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == target)
                {
                    output = i;
                    break;
                }
                else if (nums[i] > target)
                {
                    output = i;
                    break;
                }
                else
                {
                    output = i + 1;

                }

            }
            return output;
        }
    }
}
