using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.String_Problems.Medium
{
    internal class Decode_String
    {
        public string DecodeString(string s)
        {
            StringBuilder result = new StringBuilder();
            Stack<int> stackOfCount = new Stack<int>();
            Stack<string> stackOfWord = new Stack<string>();

            int index = 0;
            while (index < s.Length)
            {
                char c = s[index];
                if (char.IsDigit(c))
                {
                    int num = 0;
                    while (char.IsDigit(s[index]))
                    {
                        num = num * 10 + (s[index] - '0');
                        index++;
                    }
                    stackOfCount.Push(num);
                }
                else if (c == '[')
                {
                    stackOfWord.Push(result.ToString());
                    result = new StringBuilder();
                    index++;
                }
                else if (c == ']')
                {
                    StringBuilder temp = new StringBuilder(stackOfWord.Pop());
                    int repeatNumber = stackOfCount.Pop();
                    int i = 0;
                    while (i < repeatNumber)
                    {
                        temp.Append(result);
                        i++;
                    }
                    result = temp;
                    index++;
                }
                else
                {
                    result.Append(c);
                    index++;
                }
            }
            return result.ToString();
        }
    }
}
