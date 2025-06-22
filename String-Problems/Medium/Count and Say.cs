using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.String_Problems.Medium
{
    internal class Count_and_Say
    {
        public string CountAndSay(int n)
        {
            if (n <= 0)
                return "";

            StringBuilder result = new StringBuilder("1");
            for (int i = 2; i <= n; i++)
            {

                string temp = result.ToString();
                result = new StringBuilder();
                for (int j = 0; j < temp.Length;)
                {
                    char currentChar = temp[j];
                    int count = 0;
                    while (j < temp.Length && temp[j] == currentChar)
                    {
                        count++;
                        j++;
                    }
                    result.Append(count);
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }
    }
}
