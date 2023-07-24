using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Minimum_Moves_to_Convert_String
    {
        public int MinimumMoves(string s)
        {
            
            int count = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == 'X')
                {
                   count++;
                    i += 2;
                        
                }
            }
            return count;

        }
    }
}
