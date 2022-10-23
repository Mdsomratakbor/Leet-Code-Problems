using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;

            k = k % length;

            int[] aux = new int[k];
            for(int i=0; i<k; i++)
            {
                aux[i] = nums[length-k+i];
            }

            for(int i=length-k-1; i>=0; i--)
            {
                nums[i + k] = nums[i];
            }
            for(int i=0; i<k; i++)
            {
                nums[i] = aux[i];
            }

        }
    }
}
