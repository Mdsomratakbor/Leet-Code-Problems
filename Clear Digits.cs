using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Clear_Digits
    {
        //cb34

        public string ClearDigits(string s)
        {
            int left = 0, right = s.Length;
            string result = string.Empty;
            while (left < right)
            {

                if (char.IsDigit(s[left]))
                {
                    if(result.Length>0)
                        result= result.Remove(result.Length - 1);
                    
                }
                else
                {
                    result+= s[left];
                }
                left++;
            }

           return result;

        }


    }
}
