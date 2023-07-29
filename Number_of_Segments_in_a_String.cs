using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Number_of_Segments_in_a_String
    {
        public int CountSegments(string s)
        {

            return s.Split(' ').Where(c=>c!= "").Count();
        }
    }
}
