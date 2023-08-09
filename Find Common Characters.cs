using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Find_Common_Characters
    {
        public IList<string> CommonChars(string[] words)
        {
            IList<string> result = new List<string>();
            foreach (char c in words[0])
            {
              
                    bool isTrue = true;
                    foreach (string word1 in words)
                    {
                        if (!word1.Contains(c))
                        {
                            isTrue = false;
                            break;
                        }
                        
                    }
                    if (isTrue)
                    {
                        result.Add(c.ToString());
                    }

                    
                
            }
            return result;

        }
    }
}
