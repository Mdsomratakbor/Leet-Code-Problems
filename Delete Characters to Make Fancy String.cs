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
         

            for(int i=0; i<s.Length; i++)
            {
                int count = 0;
                for(int j=i; j<s.Length; j++)
                {
                    if (s[i]== s[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > 2 && i + 2 < s.Length)
                {
                    s = s.Remove(i + 2, count - 2);
                    i += count - 2;
                }

            }
            return s;
        }
    }
}
