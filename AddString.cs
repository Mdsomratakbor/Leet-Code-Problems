using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class AddString
    {
        public string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
            string result = "";

            while (i >= 0 || j >= 0 || carry>0)
            {
                int digit1 = i>=0? (int)num1[i] - '0' : 0;
                int digit2 = j >= 0 ? (int)num2[j] - '0' : 0;
                int total  = digit1 + digit2 + carry;
                carry = total / 10;
                result =   (total% 10)+ result;
                i--;
                j--;
            }
            return result;
        }
    }
}
