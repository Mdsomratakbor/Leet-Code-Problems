using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Divide_Two_Integers
    {
        public int Divide(int dividend, int divisor)
        {

           
            if (divisor == 0)
                return Int32.MaxValue;
            if (divisor == -1 && dividend == Int32.MinValue)
                return Int32.MaxValue;

            int sign = (dividend<0 ^ divisor<0)?-1: 1;
            int count = 0;
            long dividend2 = Math.Abs((long)dividend);
            long divisor2 = Math.Abs((long)divisor);
            while (dividend2 >= divisor2)
            {
                dividend2 -= divisor2;
                count++;
            
            }
            count = sign == -1  ? -count : count;
            return count;
        }
    }
}
