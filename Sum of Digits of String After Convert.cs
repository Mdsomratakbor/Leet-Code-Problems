using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Sum_of_Digits_of_String_After_Convert
    {
        public int GetLuckyConvertion(string s, int k)
        {
            string numericString = "";
            int result = 0;
            foreach (char c in s)
            {
                numericString += c - 'a' + 1;

            }
            int i = 0;
            while (i < k)
            {
                result = 0;
                foreach (int number in numericString)
                {
                    result += number - '0';
                }
                numericString = result.ToString();
                i++;
            }
            return result;
        }
        public int GetLucky(string s, int k)
        {

            int sum = 0;
            foreach (char c in s)
            {
                int value = c - 'a' + 1; 


                while (value > 0)
                {
                    sum += value % 10; 
                    value /= 10;      
                }
            }

            for (int i = 1; i < k; i++)
            {
                int newSum = 0;
                while (sum > 0)
                {
                    newSum += sum % 10; 
                    sum /= 10;         
                }
                sum = newSum; 
            }

            return sum;
        }

    }
}
