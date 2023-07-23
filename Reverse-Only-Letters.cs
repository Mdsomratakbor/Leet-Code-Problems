using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reverse_Only_Letters
    {
        public string ReverseOnlyLetters(string s)
        {

            int left = 0, right = s.Length-1;
            char[] newString = s.ToCharArray();
            while (left < right)
            {
                while (left < right && !char.IsLetter(s[left]))
                {
                    newString[left] = s[left];
                    left++;
                }
                while (left < right && !char.IsLetter(s[right]))
                {
                    newString[right] = s[right];
                    right--;
                }
                if (char.IsLetter(s[left]) && char.IsLetter(s[right]))
                {
                    char temp = s[left];
                    newString[left] = s[right];
                    newString[right] = temp;
                }
                    
                    
                    left++;
                    right--;
            }
            string result = new string(newString);
            return result;
        }

    }
}
