using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Minimum_String_Length_After_Removing_Substrings
    {
        public int MinLength(string s)
        {
            Stack<char> _queue = new Stack<char>();
            _queue.Push(' ');
            foreach (char c in s.ToCharArray())
            {
                if ((c=='B' && _queue.Peek()=='A') || c=='D' && _queue.Peek() == 'C')
                {
                    _queue.Pop();
                }
                else 
                { 
                    _queue.Push(c);
                }
            }
            return _queue.Count-1;
        }
     

    }
}
