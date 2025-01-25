using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Remove_Digit_From_Number_to_Maximize_Result
    {
        public string RemoveDigit(string number, char digit)
        {
            string maxResult  = "";
            for (int i = 0; i < number.Length; i++)
            {
                string modifiedString = "";
                if (number[i] == digit)
                {

                    modifiedString = number.Remove(i, 1);
                    if (string.Compare(modifiedString, maxResult) >0)
                    {
                        maxResult = modifiedString;
                    }
                }        
               
            }
          
            return maxResult;

        }
    }
}
