using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Valid_Parentheses
    {
        Stack<char> characterStack = new Stack<char>();
        public bool IsValid(string s)
        {
            for(int i=0; i<s.Length; i++)
            {
                if (s[i]=='['|| s[i] == '{' || s[i] == '(')
                {
                    characterStack.Push(s[i]);
                }
                if(s[i] == ']' || s[i] == '}' || s[i] == ')')
                {
                    if (characterStack.Count() == 0)
                        return false;
                    else
                    if (!IsMatchingPair(characterStack.Pop(), s[i]))
                        return false;
                }
            }

            if(characterStack.Count()==0)
                return true;

            return false;
        }

        public bool IsMatchingPair(char character1,
                                 char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }

    }
}
