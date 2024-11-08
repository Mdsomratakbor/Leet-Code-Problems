using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Valid_Palindrome_II
    {
        public bool ValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                   return (IsPalindrome(s, left+1, right)) || (IsPalindrome(s, left,right-1));
                }
                left++;
                right--;
         
            }
         

            return true;
        }
        bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }

        // Time Limit Exceeded
        //public bool ValidPalindrome(string s)
        //{
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        string newStirng = s.Remove(i, 1);
        //        int left = 0, right = newStirng.Length - 1;
        //        var array = newStirng.ToCharArray();
        //        while (left < right)
        //        {
        //            char temp = newStirng[left];
        //            array[left] = newStirng[right];
        //            array[right] = temp;
        //            left++;
        //            right--;
        //        }
        //        string n = new string(array);

        //        if (n.Equals(newStirng))
        //            return true;

        //    }

        //    return false;
        //}
    }
}
