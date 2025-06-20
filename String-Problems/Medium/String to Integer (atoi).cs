using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.String_Problems.Medium
{
    internal class String_to_Integer__atoi_
    {
        public int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int i = 0;
            int n = s.Length;
            int sign = 1;
            long result = 0;

            while (i < n && s[i] == ' ')
                i++;

            if (i < n && (s[i] == '+' || s[i] == '-'))
            {
                sign = s[i] == '-' ? -1 : 1;
                i++;
            }

            while (i < n && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                result = result * 10 + digit;
                if (sign == 1 && result > int.MaxValue)
                    return int.MaxValue;
                if (sign == -1 && -result < int.MinValue)
                    return int.MinValue;
                i++;
            }

            return (int)(sign * result);
        }
    }
}
