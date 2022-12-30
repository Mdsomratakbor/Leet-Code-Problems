using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class SortColor
    {
        public void SortColors(int[] nums)
        {
            int length = nums.Length;
            for(int i=0; i< length; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while(j>=0 && nums[j] > key)
                {
                    nums[j+1]=nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }
        }
    }
}
