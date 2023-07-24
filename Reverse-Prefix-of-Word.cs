using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reverse_Prefix_of_Word
    {
        public string ReversePrefix(string word, char ch)
        {
            char[] newArray = word.ToCharArray();
            for (int i=0; i<word.Length; i++)
            {
                if (word[i] == ch)
                {
                    int left = 0, right = i;
                    while (left < right)
                    {
                        char temp = newArray[left];
                        newArray[left] = newArray[right];
                        newArray[right] = temp;
                        left++;
                        right--;
                    }
                    break;
                }
            }
            string result = new string(newArray);
            return result;
        }
    }
}
