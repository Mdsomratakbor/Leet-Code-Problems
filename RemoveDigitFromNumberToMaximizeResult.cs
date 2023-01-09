using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class RemoveDigitFromNumberToMaximizeResult
    {
        public string RemoveDigit(string number, char digit)
        {
           StringBuilder stringBuilder = new StringBuilder();
            int[] numArray = new int[] { };
            for (int i=0; i<number.Length; i++)
            {
                if (number[i] == digit)
                {
                    stringBuilder.Append(i);
                    numArray.Append(i);
                }
            }
            if (stringBuilder.Length == 1)
            {
                var valu1 = numArray.Length;
                var value = Convert.ToInt16(stringBuilder[0]);
                return number.Remove(value);
            }
            else
            {
                return number;
            }
        }
    }
}
