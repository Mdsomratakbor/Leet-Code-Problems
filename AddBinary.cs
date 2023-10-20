using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class AddBinaryProblem
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int carryBit = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            while(i>=0 || j >= 0)
            {
                int sum = carryBit;
                if (i >= 0)
                {
                    sum += a[i--] - '0';
                }
                if (j >= 0)
                {
                    sum += b[j--] - '0';
                }
                result.Insert(0, sum%2);
                carryBit = sum / 2;
            }

            // Final check if carry exists
            if (carryBit > 0)
            {
                result.Insert(0, 1);
            }
            return result.ToString();
        }
    }
}
