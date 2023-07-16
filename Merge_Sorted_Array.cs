using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            nums1 = new int[m + n];
            int length = 0;
            for (int i = 0; i < m; i++)
            {
                nums1[length++] = nums1[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums1[length++] = nums2[i];
            }
            nums1 = SortOptimizedArray(nums1);
         
           

        }
        public int[] SortOptimizedArray(int[] NumArray)
        {
            var n = NumArray.Length;
            bool swapRequired;
            for (int i = 0; i < n - 1; i++)
            {
                swapRequired = false;
                for (int j = 0; j < n - i - 1; j++)
                    if (NumArray[j] > NumArray[j + 1])
                    {
                        var tempVar = NumArray[j];
                        NumArray[j] = NumArray[j + 1];
                        NumArray[j + 1] = tempVar;
                        swapRequired = true;
                    }
                if (swapRequired == false)
                    break;
            }
            return NumArray;
        }
    }
}
