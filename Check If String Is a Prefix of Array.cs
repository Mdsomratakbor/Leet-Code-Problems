using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Check_If_String_Is_a_Prefix_of_Array
    {
        public bool IsPrefixString(string s, string[] words)
        {

            StringBuilder newString = new StringBuilder();

            foreach (var word in words)
            {

                newString.Append(word);
                
                if (s == newString.ToString())
                    return true;

                if (newString.Length > s.Length)
                    return false;
            }

            return false;
        }
    }
}
