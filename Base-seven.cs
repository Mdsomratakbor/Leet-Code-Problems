using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    /// <summary>
    /// Problem Name is  Base 7
    /// </summary>
    internal class Base_seven
    {
        public string ConvertToBase7(int num)
        {
           StringBuilder stringBuilder = new StringBuilder();

            bool negatingNumber=  false;
            if (num == 0)
                return "0";

            if (num < 0)
            {
                num = Math.Abs(num);
                negatingNumber = true;
            }
            

            while (num > 0)
            {
                stringBuilder.Append(num%7);
                num /= 7;
            }
           string result = stringBuilder.ToString();
            result = result.Reverse().ToString();
            if (negatingNumber)
            {
                result.Concat("-");
                
            }
            return stringBuilder.ToString();

        }
    }
}
