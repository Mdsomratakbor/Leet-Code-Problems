using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Occurrences_After_Bigram
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            string[] strings =  text.Split(' ');
            IList<string> result = new List<string>();
            for(int i=0; i<strings.Length-1; ++i)
            {
                if (strings[i] == first && strings[i + 1] == second)
                {
                    if(i + 2 < strings.Length)
                    {
                        result.Add(strings[i + 2]);
                    }
                    
                }
            }
            return result.ToArray();
        }
    }
}
