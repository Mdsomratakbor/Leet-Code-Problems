using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Find_Maximum_Number_of_String_Pairs
    {
        public int MaximumNumberOfStringPairs(string[] words)
        {

            int count = 0;
           for(int i=0; i<words.Length; i++)
            {
                for(int j=i+1; j<words.Length; j++)
                {
                    int left = 0;
                    int right = words[j].Length-1;
                    char[] chars = words[j].ToCharArray(); 
                    while (left < right)
                    {
                        char temp = words[j][left];
                        chars[left] = words[j][right];
                        chars[right] = temp;
                        left++;
                        right--;
                    }
                    
                    string currentWord = new string(chars);
                    if (words[i] == currentWord)
                    {
                        count++;
                    }


                }
            }
           return count;
        }
    }
}
