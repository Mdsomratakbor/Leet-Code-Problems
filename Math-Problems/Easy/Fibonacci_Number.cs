using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Math_Problems.Easy
{
    internal class Fibonacci_Number
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n; // Base case: F(0) = 0, F(1) = 1
            }

      
            int[] fibArray = new int[n + 1];
            fibArray[0] = 0;
            fibArray[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }

            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += fibArray[i];
            }
            return sum;
        }
    }
}
