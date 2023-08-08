using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reverse_String_II
    {
        public string ReverseStr(string s, int k)
        {
            char[] sArray = s.ToCharArray();
            int length = sArray.Length;
            int left = 0;

            while (left < length)
            {
                int right = Math.Min(left + k - 1, length - 1);
                ReverseSubstring(sArray, left, right);
                left += 2 * k;
            }

            return new string(sArray);
        }

        private void ReverseSubstring(char[] arr, int start, int end)
        {
            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
