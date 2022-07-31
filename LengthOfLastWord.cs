using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWordSolution(string s)
        {

            string[] arrayOfString = s.Trim().Split();
            return arrayOfString[arrayOfString.Length - 1].Length;
        }
    }
}
