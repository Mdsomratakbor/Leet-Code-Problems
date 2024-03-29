﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Power_of_xn
    {
        public double MyPow(double x, int n)
        {
            double temp;

            if (n == 0)
                return 1;
            temp = MyPow(x, n / 2);

            if (n % 2 == 0)
                return temp * temp;
            else
            {
                if (n > 0)
                    return x * temp * temp;
                else
                    return (temp * temp) / x;
            }

        }
    }
}
