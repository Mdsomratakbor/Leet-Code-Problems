using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Make_The_String_Great
    {
        public string MakeGood(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if(stack.Count > 0 && Math.Abs(stack.Peek() - c) == 32)
                {
                    stack.Pop();
                }
                else
                    stack.Push(c);
            }

            return new string(stack.Reverse().ToArray());
        }
    }
}
