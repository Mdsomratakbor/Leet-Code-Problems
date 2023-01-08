using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MaximumValueofaStringinanArray
    {
        public int MaximumValue(string[] strs)
        {
            int maxNumber = 0;
            for(int i=0; i < strs.Length; i++)
            {
                int number = 0;
                if (Int32.TryParse(strs[i],out number))
                {
                    if(number>maxNumber)
                        maxNumber = number;
                }
                else
                {
                    if (strs[i].Length > maxNumber)
                    {
                        maxNumber = strs[i].Length;
                    }
                }
            }
            return maxNumber;
        }
    }
}
