using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Find_the_Difference
    {
        public char FindTheDifference(string s, string t)
        {
            //var c = ' ';
            //foreach(var charater in t)
            //{
            //    if (!s.Contains(charater))
            //    {
            //        c = charater;
            //        break;
            //    }
            //}
            // if (s.Length == 0)
            //     return t[0];
            //var c = t.Substring(0, s.Length - 1);
            // return c[0];


            foreach (char c in s)
            {
                t = t.Remove(t.IndexOf(c), 1);
            }
            return t[0];
        }
    }
}
