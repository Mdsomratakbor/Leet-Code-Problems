using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            bool output = true;
            for(int i =0; i<word.Length; i++)
            {
                if (i != 0)
                {
                    if (char.IsLower(word[i]))
                    {
                        output = false;
                    }
                      
                }
                else
                {
                    if (i == 0)
                    {
                        if (char.IsUpper(word[i]))
                        {
                            output = true;
                        }
                    }
                    else
                    {
                        if (char.IsUpper(word[i]))
                        {
                            output = true;
                        }
                    }
                  

                }
                
               
            }
            return output;
        }
    }
}
