using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Delete_Characters_to_Make_Fancy_String
    {
        public string MakeFancyString(string s)
        {
            int left = 1, right = s.Length;
            StringBuilder result = new StringBuilder();
            result.Append(s[0]);

            int count = 1;

            while (left < right)
            {

                if (s[left - 1] == s[left])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count < 3)
                {
                    result.Append(s[left]);
                }

                left++;
            }

            return result.ToString();
        }
    }
}
