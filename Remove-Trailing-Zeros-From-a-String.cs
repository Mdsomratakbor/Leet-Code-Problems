using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Remove_Trailing_Zeros_From_a_String
    {
        public string RemoveTrailingZeros(string num)
        {
            for (int i = num.Length - 1; i>=0; i--)
            {
                if (num[i] != '0')
                {
                    num = num.Substring(0, i+=1);
                    break;

                }
            }
            return num;
        }
    }
}
