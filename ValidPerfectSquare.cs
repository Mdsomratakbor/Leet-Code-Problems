using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num >= 0)
            {
                int number =(int) Math.Sqrt(num);
                return (number*number == num);
            }

            return false;
        }
    }
}
