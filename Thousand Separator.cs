using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Thousand_Separator
    {
        public string ThousandSeparator(int n)
        {

            StringBuilder result = new StringBuilder(n.ToString());

            int count = 0;

            int length = result.Length;
           for(int i=length-3; i>0; i -= 3)
            {
                result.Insert(i, ".");
            }



            return result.ToString();
        }
    }
}
