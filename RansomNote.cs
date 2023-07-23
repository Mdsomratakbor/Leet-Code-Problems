using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            return magazine.Contains(ransomNote);
        }
    }
}
