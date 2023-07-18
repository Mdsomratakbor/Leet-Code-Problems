using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Reverse_Words_in_a_String_III
    {
        public string ReverseWords(string s)
        {
            var listOfData= s.Split(' ').ToList();

            StringBuilder newStringFormat = new();
            foreach (var item in listOfData)
            {
                var perWoardArray = item.ToCharArray();
                int left = 0;
                int right = perWoardArray.Length - 1;
                while (left < right)
                {
                    char temp = perWoardArray[left];
                    perWoardArray[left] = perWoardArray[right];
                    perWoardArray[right] = temp;
                    left++;
                    right--;
                }
                string newString = new string(perWoardArray);
                if (newStringFormat.Length > 0)
                {
                    newString = " " + newString;
                }

                newStringFormat.Append(newString);
            }
            
            return newStringFormat.ToString();

        }
    }
}
