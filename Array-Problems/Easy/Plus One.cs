using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array_Problems.Easy
{
    public class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            string a ="";
            int output;
            foreach (int test in digits)
            {
                a += test.ToString();
            }
            output = int.Parse(a);
            output += 1;

            List<int> digitList = new List<int>();
            while (output > 0)
            {
                int digit = output % 10;
                digitList.Insert(0, digit); // Insert the digit at the beginning of the list
                output /= 10; // Remove the last digit
            }

            int[] intArray = digitList.ToArray();
            return intArray;
        }
    }
}
