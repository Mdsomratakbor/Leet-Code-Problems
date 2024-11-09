using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Count_the_Number_of_Special_Characters_I
    {
        
            public int NumberOfSpecialChars(string word)
            {
                HashSet<char> lowers = new HashSet<char>();
                HashSet<char> uppers = new HashSet<char>();
                foreach (char c in word)
                {
                   
                        if (char.IsLower(c))
                        {
                            lowers.Add(c);
                        }
                   
                        if (char.IsUpper(c))
                        {
                            uppers.Add(c);
                        }
                    
                }
                int count = 0;
                foreach (char c in uppers)
                {
                    if (lowers.Contains(char.ToLower(c)))
                    {
                        count++;
                    }
                }

                return count;
            }
        
    }
}
