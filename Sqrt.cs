using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            long low = 0, high = x;
            long res =0;
            while (low<= high)
            {
                long mid = (low + high) / 2;
                long mulMid = mid * mid;
                if (mulMid == x)
                    return (int)mid;

                if (mulMid > x)
                {
                    high = mid - 1;

                }
                else
                {
                    low= mid + 1;
                    res = mid;
                }
            }  
            return (int)res;
   
        }
    }
}
