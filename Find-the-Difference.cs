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
            char c = ' ';
            if (s.Length == 0 && t.Length>0)
                return t[0];

           
             
                    
                        c=  t[s.Length];
                   
                    
                
            

            return c;
        }
    }
}
