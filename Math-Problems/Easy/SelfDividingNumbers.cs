using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Math_Problems.Easy
{
    internal class Self_DividingNumbers
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();
            for(int i=left; i<=right; i++)
            {
                int num = i;
                bool isdivisable = true;
                while(num > 0)
                {
                    int digit = (num % 10);
                    //if (digit>0)
                    //{
                        if (digit == 0 || i % digit!= 0)
                        {
                            isdivisable = false;
                            break;
                        }
                    //}
                    //else
                    //{
                    //    isdivisable = false;
                    //    break;
                    //}

                    num = num / 10;
                }
                if (isdivisable)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
