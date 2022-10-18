using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Sum_of_Square_Numbers
    {
        public bool JudgeSquareSum(int c)
        {
            long left = 0;
            long right =(long) Math.Sqrt(c);

            while (left <= right)
            {
                if (left * left + right * right == c)
                    return true;
                if(left * left + right * right > c)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            //  HACK: When input 999999999 then this code is time limit exit;
            // int number = 0;
            //for(int i=0; i<=c; i++)
            // {
            //     for(int j=0; j <= c; j++)
            //     {
            //         if (i * i + j * j > c)
            //             break;
            //         else
            //         {
            //             number = i * i + j * j;
            //             if (number == c)
            //                 return true;
            //         }

            //     }
            //     if (number > c)
            //         break;
            // }
            return false ;
        }
    }
}
