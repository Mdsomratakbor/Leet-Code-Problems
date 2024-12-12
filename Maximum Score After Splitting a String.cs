using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Maximum_Score_After_Splitting_a_String
    {
        public int MaxScore(string s)
        {
            int result = 0, totalOneCount = s.Count(x => x == '1'), zeroCount = 0, oneCountLeft = 0, oneCountRight = 0, left = 0, right = s.Length-1, currentScore= 0 ;

            while (left < right)
            {
                if (s[left] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    oneCountLeft++;
                }

                oneCountRight = totalOneCount - oneCountLeft;

                currentScore = oneCountRight + zeroCount;

                result = Math.Max(result, currentScore);
                left++;

            }
            
            return result;
        }
        /// <summary>
        /// Time Complexity Analysis: O(n×n)=O(n2)
        /// Memory Complexity Analysis:O(n2)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MaxScore_Old(string s)
        {
            int left = 0, right = s.Length;
            int sum = 0, tempSum = 0;
            while (left < right)
            {
                string leftString = s.Substring(0, left + 1);
                string rightString = s.Substring(left + 1, right - left - 1);

                int oneCount = 0, zeroCount = 0;

                if (rightString.Length > 0 && leftString.Length > 0)
                {
                    oneCount = rightString.Count(x => x == '1');
                    zeroCount = leftString.Count(x => x == '0');
                }
                tempSum = oneCount + zeroCount;


                if (tempSum > sum)
                {
                    sum = tempSum;
                }
                left++;
            }
            return sum;
        }
    }
}
